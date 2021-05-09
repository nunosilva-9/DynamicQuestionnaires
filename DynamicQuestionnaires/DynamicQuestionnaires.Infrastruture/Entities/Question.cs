using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
