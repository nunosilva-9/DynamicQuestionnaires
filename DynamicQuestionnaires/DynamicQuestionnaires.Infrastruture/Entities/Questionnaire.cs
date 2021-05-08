using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Entities
{
    public class Questionnaire
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Question StartQuestion { get; set; }

        public int StartQuestionId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
