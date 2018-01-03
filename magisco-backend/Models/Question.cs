using Magisco.Profile.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magisco.Profile.Models
{
    public class Question
    {
        public Guid QuestionID { get; set; }
        public string QuestionPhrased { get; set; }
        public QuestionFor QuestionFor { get; set; }
        public DateTime DateCreated { get; set; }

    }
}