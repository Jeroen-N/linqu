using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class OpenAnswer : Answer
    {
        public Guid OpenAnswerID { get; set; }

        public String Value { get; set; }
    }
}
