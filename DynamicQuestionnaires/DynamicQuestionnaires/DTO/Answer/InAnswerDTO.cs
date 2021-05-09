using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Application.DTO.Question
{
    public class InAnswerDTO
    {
        [Required]
        public string Description { get; set; }

        public InQuestionDTO Question { get; set; }
    }
}
