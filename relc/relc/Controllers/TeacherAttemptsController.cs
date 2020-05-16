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
    [Route("/teacher/attempts")]
    public class TeacherAttemptsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;

        public TeacherAttemptsController(
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Attempt>> GetAllAsync()
        {
            return await _context.Attempts
                .Include(e => e.Answers)
                .Include(a => a.Exam)
                    .ThenInclude(e => e.Questions)
                .Include(a => a.Login)
                .ToListAsync();
        }

        [HttpGet("{AttemptId}")]
        public async Task<Attempt> GetAsync(int AttemptId)
        {
            return await _context.Attempts
                .Include(e => e.Answers)
                .Include(a => a.Exam)
                    .ThenInclude(e => e.Questions)
                .Include(a => a.Login)
                .Where(a => a.AttemptId == AttemptId)
                .FirstOrDefaultAsync();
        }
    }
}
