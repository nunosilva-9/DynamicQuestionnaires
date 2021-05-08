﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.Infrastruture.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
