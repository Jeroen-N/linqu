﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqu.profileservice.Models
{
    public class ListQuestion : BaseQuestion
    {
        public int AmountOfListOptions { get; set; }
        public ICollection<String> Options { get; set; }
    }
}
