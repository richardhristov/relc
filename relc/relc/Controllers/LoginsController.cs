using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using relc.Data;
using relc.Models;

namespace relc.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LoginsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public LoginsController(
            IConfiguration configuration,
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _configuration = configuration;
            _context = context;
            _logger = logger;
        }

        public class AuthenticateModel
        {
            [Required]
            [StringLength(30, MinimumLength = 3)]
            public string Username { get; set; }

            [Required]
            [StringLength(30, MinimumLength = 3)]
            public string Password { get; set; }
        }

        public class AuthenticationResponse
        {
            public int LoginId { get; set; }

            public string Token { get; set; }
        }

        [HttpGet]
        public async Task<IEnumerable<Login>> GetAllAsync()
        {
            _logger.LogDebug("GET /logins");
            return await _context.Logins.ToListAsync();
        }

        [HttpGet("{LoginId}")]
        public async Task<Login> GetAsync(int LoginId)
        {
            _logger.LogDebug("GET /logins/"+LoginId);
            return await _context.Logins
                .Where(l => l.LoginId == LoginId)
                .FirstOrDefaultAsync();
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticationResponse>> PostAuthenticateAsync(AuthenticateModel authenticateModel)
        {
            _logger.LogDebug("POST /authenticate", authenticateModel);
            var login = await _context.Logins
                .Where(l => l.Username == authenticateModel.Username)
                .FirstOrDefaultAsync();
            if (login == null || !login.PasswordCompare(authenticateModel.Password))
            {
                _logger.LogDebug("Login credentials invalid", authenticateModel);
                return NotFound("Username or password does not exist");
            }

            _logger.LogDebug("Succesful login", authenticateModel);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, login.LoginId.ToString()),
                    new Claim(ClaimTypes.Role, login.Type.ToString()),
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new AuthenticationResponse()
            {
                LoginId = login.LoginId,
                Token = tokenHandler.WriteToken(token),
            };
        }
    }
}
