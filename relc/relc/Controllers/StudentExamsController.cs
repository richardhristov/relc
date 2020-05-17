using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using relc.Data;
using relc.Models;

namespace relc.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/student/exams")]
    public class StudentExamsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;

        public StudentExamsController(
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Exam>> GetAllAsync()
        {
            var exams = await _context.Exams
                .Include(e => e.Questions)
                .Where(e => e.IsActive)
                .ToListAsync();
            foreach (var item in exams)
            {
                item.HideAnswers();
            }
            return exams;
        }

        [HttpGet("{ExamId}")]
        public async Task<Exam> GetAsync(int ExamId)
        {
            var exam = await _context.Exams
                .Include(e => e.Questions)
                .Where(e => e.ExamId == ExamId)
                .Where(e => e.IsActive)
                .FirstOrDefaultAsync();
            exam.HideAnswers();
            return exam;
        }
    }
}
