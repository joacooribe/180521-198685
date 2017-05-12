﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Blackboard
    {
        public User ownerUser { get; set; }
        public string description { get; set; }
        public int high { get; set; }
        public string name { get; set; }
        public Team ownerTeam { get; set; }
        public int width { get; set; }
    }
}