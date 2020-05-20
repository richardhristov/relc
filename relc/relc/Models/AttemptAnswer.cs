using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace relc.Models
{
    public class AttemptAnswer
    {
        public int AttemptAnswerId { get; set; }

        public int AttemptId { get; set; }
        [JsonIgnore]
        public Attempt Attempt { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer { get; set; }

        [Required]
        [Range(1, 1000)]
        public short Score { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
    }
}
