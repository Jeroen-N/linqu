using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace magisco.profileservice.Models
{
    public class BoolQuestion : Question
    {
        public string LabelTrue { get; set; }
        public string LabelFalse { get; set; }
    }
}
