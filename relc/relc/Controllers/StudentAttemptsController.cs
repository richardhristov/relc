﻿using System;
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
    [Route("/student/attempts")]
    public class StudentAttemptsController : ControllerBase
    {
        private readonly ILogger<TeacherExamsController> _logger;
        private readonly ApplicationDbContext _context;

        public StudentAttemptsController(
            ApplicationDbContext context,
            ILogger<TeacherExamsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Attempt>> GetAllAsync()
        {
            _logger.LogDebug("GET /students/attempts");
            var loginId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value);
            return await _context.Attempts
                .Where(a => a.LoginId == loginId)
                .Include(e => e.Answers)
                .Include(a => a.Exam)
                    .ThenInclude(e => e.Questions)
                .ToListAsync();
        }

        [HttpGet("{AttemptId}", Name = nameof(StudentAttemptsController) + nameof(GetAsync))]
        public async Task<Attempt> GetAsync(int AttemptId)
        {
            _logger.LogDebug("GET /students/attempts/"+AttemptId);
            var loginId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value);
            return await _context.Attempts
                .Where(a => a.LoginId == loginId)
                .Include(e => e.Answers)
                .Include(a => a.Exam)
                    .ThenInclude(e => e.Questions)
                .Where(a => a.AttemptId == AttemptId)
                .FirstOrDefaultAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Attempt>> PostAsync(Attempt attempt)
        {
            _logger.LogDebug("POST /students/attempts", attempt);
            var loginId = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault().Value);
            var exam = await _context.Exams
                .Include(e => e.Questions)
                .Where(e => e.ExamId == attempt.ExamId)
                .FirstOrDefaultAsync();

            if (exam == null)
            {
                return NotFound("Exam was not found");
            }

            var oldAttempt = await _context.Attempts
                .Where(a => a.ExamId == exam.ExamId)
                .Where(a => a.LoginId == loginId)
                .FirstOrDefaultAsync();
            if (oldAttempt != null)
            {
                return BadRequest("You already attempted this exam, you can only do one attempt");
            }

            attempt.LoginId = loginId;

            short scorePossible = 0;
            short score = 0;
            var questionIds = new List<int>();
            foreach (var item in attempt.Answers)
            {
                if (questionIds.Contains(item.QuestionId))
                {
                    continue;
                }
                questionIds.Add(item.QuestionId);

                var question = exam.Questions
                    .Where(q => q.QuestionId == item.QuestionId)
                    .FirstOrDefault();
                if (question == null)
                {
                    return BadRequest("Question not found");
                }
                if (!question.IsOptional)
                {
                    scorePossible += question.Score;
                }
                item.Score = 0;
                if (question.CheckAnswer(item.Answer))
                {
                    score += question.Score;
                    item.Score = question.Score;
                }
            }

            if (scorePossible > exam.ScoreMax)
            {
                return BadRequest("The computed score was invalid");
            }

            attempt.Score = score;

            if (score >= exam.GradingScoreMax)
            {
                attempt.Grade = 6m;
            }
            else if(score < exam.GradingScoreMin)
            {
                attempt.Grade = 2m;
            }
            else
            {
                var range = exam.GradingScoreMax - exam.GradingScoreMin;
                var scoreOverMin = score - exam.GradingScoreMin;
                attempt.Grade = ((scoreOverMin / (decimal)range) * 4m) + 2;
            }

            switch (exam.RoundingMethod)
            {
                case RoundingMethod.Closest:
                    attempt.GradeRounded = (short)Math.Round(attempt.Grade);
                    break;
                case RoundingMethod.Down:
                    attempt.GradeRounded = (short)Math.Floor(attempt.Grade);
                    break;
                case RoundingMethod.Up:
                    attempt.GradeRounded = (short)Math.Ceiling(attempt.Grade);
                    break;
                throw new NotImplementedException();
            }

            _context.Attempts.Add(attempt);
            await _context.SaveChangesAsync();
            return CreatedAtRoute(nameof(StudentAttemptsController) + nameof(GetAsync), new { AttemptId = attempt.AttemptId }, attempt);
        }
    }
}
