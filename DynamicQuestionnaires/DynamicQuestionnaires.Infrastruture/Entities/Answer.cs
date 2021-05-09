using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int QuestionId { get; set; }

        public Question Question { get; set; }

       // public int NextQuestionId { get; set; }

       // public Question NextQuestion { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
