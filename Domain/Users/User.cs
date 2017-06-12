﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class User
    {
        public string name { get; set; } 
        public string surname { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public DateTime birthday { get; set; }
        public bool active { get; set; }
    }
}
