﻿using linqu.profileservice.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class Answer
    {
        public Guid AnswerID { get; set; }

        public DateTime TimeAnswered { get; set; }

        public AnswerType AnswerType { get; set; }
    }
}
