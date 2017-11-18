using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class QuestionSet
    {
        public Guid QuestionSetID { get; set; }
        public QuestionFor QuestionSetFor { get; set; }
        public string Category { get; set; }
        public ICollection<BaseQuestion> Questions { get; set; }
    }
}