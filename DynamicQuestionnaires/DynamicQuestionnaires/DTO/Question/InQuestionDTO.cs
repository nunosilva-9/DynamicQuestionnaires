using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Application.DTO.Question
{
    public class InQuestionDTO
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public List<string> Answers { get; set; }
    }
}
