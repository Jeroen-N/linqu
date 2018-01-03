using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magisco.Profile.Models
{
    public class ListQuestion : Question
    {
        public int AmountOfListOptions { get; set; }
        public ICollection<String> Options { get; set; }
    }
}
