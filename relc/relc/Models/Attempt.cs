using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace relc.Models
{
    public class Attempt
    {
        public int AttemptId { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public int LoginId { get; set; }
        public Login Login { get; set; }

        [Required]
        [Range(1, 43200)]
        public short TimeTaken { get; set; }

        public short Score { get; set; }

        public decimal Grade { get; set; }

        public short GradeRounded { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        public IList<AttemptAnswer> Answers { get; set; }
    }
}
