using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magisco.Profile.Models
{
    public class AnswerSet
    {
        public Guid AnswerSetID { get; set; }

        public Guid QuestionSetID { get; set; }

        public bool Completed { get; set; }

        public DateTime TimeCompleted { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
