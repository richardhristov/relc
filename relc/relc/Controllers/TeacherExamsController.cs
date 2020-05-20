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
    [Authorize(Policy = "TeachersOnly")]
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
            _logger.LogDebug("GET /teacher/exams");
            return await _context.Exams
                .Include(e => e.Questions)
                .ToListAsync();
        }

        [HttpGet("active")]
        public async Task<IEnumerable<Exam>> GetAllActiveAsync()
        {
            _logger.LogDebug("GET /teacher/exams/active");
            return await _context.Exams
                .Where(e => e.IsActive == true)
                .Include(e => e.Questions)
                .ToListAsync();
        }

        [HttpGet("inactive")]
        public async Task<IEnumerable<Exam>> GetAllInactiveAsync()
        {
            _logger.LogDebug("GET /teacher/exams/inactive");
            return await _context.Exams
                .Where(e => e.IsActive == false)
                .Include(e => e.Questions)
                .ToListAsync();
        }

        [HttpGet("{ExamId}")]
        public async Task<Exam> GetAsync(int ExamId)
        {
            _logger.LogDebug("GET /teacher/exams/"+ExamId);
            return await _context.Exams
                .Include(e => e.Questions)
                .Where(e => e.ExamId == ExamId)
                .FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Exam>> PostAsync(Exam exam)
        {
            _logger.LogDebug("POST /teacher/exams"+exam);
            if (exam.Questions.Count < 1)
            {
                return BadRequest("Exam did not have any questions");
            }

            exam.IsActive = false;
            exam.IsEditable = true;
            exam.ScoreMax = (short)exam.Questions.Where(q => q.IsOptional == false).Sum(q => q.Score);
            _context.Exams.Add(exam);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAsync), new { ExamId = exam.ExamId }, exam);
        }

        [HttpPut("{ExamId}")]
        public async Task<ActionResult> PutAsync(int ExamId, Exam exam)
        {
            _logger.LogDebug("PUT /teacher/exams" + exam);
            if (exam.Questions.Count < 1)
            {
                return BadRequest("Exam did not have any questions");
            }

            if (ExamId != exam.ExamId)
            {
                return BadRequest("Exam id was invalid");
            }

            var existingExam = await _context.Exams.FindAsync(ExamId);
            if (existingExam == null)
            {
                return NotFound("Existing exam not found");
            }

            existingExam.IsActive = exam.IsActive;
            if (existingExam.IsActive)
            {
                existingExam.IsEditable = false;
            }

            if (existingExam.IsEditable)
            {
                existingExam.Name = exam.Name;
                existingExam.GradingScoreMax = exam.GradingScoreMax;
                existingExam.GradingScoreMin = exam.GradingScoreMin;
                existingExam.ScoreMax = exam.ScoreMax;
                existingExam.RoundingMethod = exam.RoundingMethod;
                existingExam.TimeLimitSeconds = exam.TimeLimitSeconds;
                existingExam.Questions = exam.Questions;
                existingExam.ScoreMax = (short)exam.Questions.Where(q => q.IsOptional == false).Sum(q => q.Score);
            }

            _context.Entry(existingExam).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{ExamId}")]
        public async Task<ActionResult<Exam>> DeleteAsync(int ExamId)
        {
            _logger.LogDebug("DELETE /teacher/exams" + ExamId);

            var existingExam = await _context.Exams.FindAsync(ExamId);
            if (existingExam == null)
            {
                return NotFound("Existing exam not found");
            }

            if (existingExam.IsActive || !existingExam.IsEditable)
            {
                return BadRequest("Exam is not deleteable");
            }

            _context.Exams.Remove(existingExam);
            await _context.SaveChangesAsync();

            return existingExam;
        }

        private bool ExamExists(int id) =>
            _context.Exams.Any(e => e.ExamId == id);
    }
}
