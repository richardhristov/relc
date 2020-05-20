using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace relc.Models
{
    public enum QuestionType
    {
        String,
        Int,
        SingleOption,
    }

    public class Question
    {
        public int QuestionId { get; set; }

        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 3)]
        public string Name { get; set; }

        public QuestionType Type { get; set; }

        [StringLength(1000)]
        public string Options { get; set; }

        [Required]
        [StringLength(100)]
        public string Answer { get; set; }

        [Required]
        [Range(1, 1000)]
        public short Score { get; set; }

        public bool IsOptional { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public IList<string> OptionsList
        {
            get
            {
                if (Type != QuestionType.SingleOption || string.IsNullOrEmpty(Options))
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<IList<string>>(Options);
            }
            set
            {
                if (Type != QuestionType.SingleOption)
                {
                    return;
                }
                Options = JsonConvert.SerializeObject(value);
            }
        }

        public bool CheckAnswer(object answer)
        {
            switch (Type)
            {
                case QuestionType.String:
                    return (string)answer == Answer;

                case QuestionType.Int:
                case QuestionType.SingleOption:
                    return int.Parse((string)answer) == int.Parse(Answer);
            }
            throw new NotImplementedException();
        }

        public void HideAnswers()
        {
            Answer = null;
        }
    }
}
