using magisco.profileservice.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magisco.profileservice.Models
{
    public class QuestionSet
    {
        public Guid QuestionSetID { get; set; }
        public QuestionFor QuestionSetFor { get; set; }
        public string Category { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}