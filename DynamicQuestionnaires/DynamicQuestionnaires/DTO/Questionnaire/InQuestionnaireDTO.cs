using DynamicQuestionnaires.Application.DTO.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Application.DTO.Questionnaire
{
    public class InQuestionnaireDTO
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public InQuestionDTO question { get; set; }
    }
}
