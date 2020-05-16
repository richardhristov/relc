using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace relc.Models
{
    public enum RoundingMethod
    {
        Closest,
        Up,
        Down,
    }

    public class Exam
    {
        public int ExamId { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public bool IsEditable { get; set; } = true;

        public RoundingMethod RoundingMethod { get; set; }

        [Required]
        [Range(1, 1000)]
        public short ScoreMax { get; set; }

        [Required]
        [Range(1, 1000)]
        public short GradingScoreMin { get; set; }

        [Required]
        [Range(1, 1000)]
        public short GradingScoreMax { get; set; }

        [Required]
        [Range(1, 43200)]
        public short TimeLimitSeconds { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public IList<Question> Questions { get; set; }
        public IList<Attempt> Attempts { get; set; }

        public void HideAnswers()
        {
            foreach (var item in Questions)
            {
                item.HideAnswers();
            }
        }
    }
}
