using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class BoolAnswer : Answer
    {
        public Guid BoolAnswerID { get; set; }

        public bool Value { get; set; }
    }
}
