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
    [Route("/teacher/exams")]
    public class TeacherExamsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;

        public TeacherExamsController(
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Exam>> GetAllAsync()
        {
            return await _context.Exams
                .Include(e => e.Questions)
                .ToListAsync();
        }

        [HttpGet("{ExamId}")]
        public async Task<Exam> GetAsync(int ExamId)
        {
            return await _context.Exams
                .Include(e => e.Questions)
                .Where(e => e.ExamId == ExamId)
                .FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Exam>> PostAsync(Exam exam)
        {
            if (exam.Questions.Count < 1)
            {
                return BadRequest();
            }

            exam.IsActive = false;
            exam.IsEditable = true;
            exam.ScoreMax = (short)exam.Questions.Sum(q => q.Score);
            _context.Exams.Add(exam);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsync), new { ExamId = exam.ExamId }, exam);
        }

        [HttpPut("{ExamId}")]
        public async Task<ActionResult> PutAsync(int ExamId, Exam exam)
        {
            if (ExamId != exam.ExamId || exam.Questions.Count < 1)
            {
                return BadRequest();
            }

            var existingExam = await _context.Exams.FindAsync(ExamId);
            if (existingExam == null)
            {
                return NotFound();
            }

            if (existingExam.IsActive || !existingExam.IsEditable)
            {
                return Unauthorized();
            }

            if (exam.IsEditable)
            {
                existingExam.IsActive = true;
                existingExam.IsEditable = false;
            }

            // TODO questions?

            existingExam.Name = exam.Name;
            existingExam.GradingScoreMax = exam.GradingScoreMax;
            existingExam.GradingScoreMin = exam.GradingScoreMin;
            existingExam.ScoreMax = exam.ScoreMax;
            existingExam.RoundingMethod = exam.RoundingMethod;
            existingExam.TimeLimitSeconds = exam.TimeLimitSeconds;
            existingExam.Questions = exam.Questions;
            existingExam.ScoreMax = (short)exam.Questions.Sum(q => q.Score);
            _context.Entry(existingExam).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{ExamId}")]
        public async Task<ActionResult<Exam>> DeleteAsync(int ExamId)
        {
            var existingExam = await _context.Exams.FindAsync(ExamId);
            if (existingExam == null)
            {
                return NotFound();
            }

            if (existingExam.IsActive || !existingExam.IsEditable)
            {
                return Unauthorized();
            }

            _context.Exams.Remove(existingExam);
            await _context.SaveChangesAsync();

            return existingExam;
        }

        private bool ExamExists(int id) =>
            _context.Exams.Any(e => e.ExamId == id);
    }
}
