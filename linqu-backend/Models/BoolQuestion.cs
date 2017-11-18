using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class BoolQuestion : BaseQuestion
    {
        public string LabelTrue { get; set; }
        public string LabelFalse { get; set; }
    }
}
