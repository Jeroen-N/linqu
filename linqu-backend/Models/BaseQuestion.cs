using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class BaseQuestion
    {
        public Guid QuestionID { get; set; }
        public string Question { get; set; }
        public QuestionFor QuestionFor { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

public enum QuestionFor { Company, Developer }