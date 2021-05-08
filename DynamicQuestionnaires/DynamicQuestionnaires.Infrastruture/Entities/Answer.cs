using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Question NextQuestion { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
