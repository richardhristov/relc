using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using relc.Data;
using relc.Models;

namespace relc.Controllers
{
    [Authorize(Policy = "StudentsOnly")]
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
            _logger.LogDebug("GET /students/exams");
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

        [HttpGet("untaken")]
        public async Task<IEnumerable<Exam>> GetAllUntakenAsync()
        {
            _logger.LogDebug("GET /students/exams/untaken");
            var loginId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value);
            var attempts = await _context.Attempts
                .Where(a => a.LoginId == loginId)
                .ToListAsync();
            var q = _context.Exams
                .Where(e => e.IsActive == true);
            foreach (var item in attempts)
            {
                q = q.Where(e => item.ExamId != e.ExamId);
            }
            var exams = await q
                .Include(e => e.Questions)
                .ToListAsync();

            foreach (var item in exams)
            {
                item.HideAnswers();
            }
            return exams;
        }

        [HttpGet("taken")]
        public async Task<IEnumerable<Exam>> GetAllTakenAsync()
        {
            _logger.LogDebug("GET /students/exams/taken");
            var loginId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value);
            var attempts = await _context.Attempts
                .Where(a => a.LoginId == loginId)
                .Include(a => a.Exam)
                .ToListAsync();
            var exams = attempts.Select(a => a.Exam).ToList();

            foreach (var item in exams)
            {
                item.HideAnswers();
            }
            return exams;
        }

        [HttpGet("{ExamId}")]
        public async Task<Exam> GetAsync(int ExamId)
        {
            _logger.LogDebug("GET /students/exams/"+ExamId);
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
