﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class AnswerSet
    {
        public Guid AnswerSetID { get; set; }

        public bool Completed { get; set; }

        public DateTime TimeCompleted { get; set; }
    }
}
