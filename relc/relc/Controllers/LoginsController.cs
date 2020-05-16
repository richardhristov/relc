using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using relc.Data;
using relc.Models;

namespace relc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;

        public LoginsController(
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Login>> GetAllAsync()
        {
            return await _context.Logins.ToListAsync();
        }

        [HttpGet("{LoginId}")]
        public async Task<Login> GetAsync(int LoginId)
        {
            return await _context.Logins
                .Where(l => l.LoginId == LoginId)
                .FirstOrDefaultAsync();
        }
    }
}
