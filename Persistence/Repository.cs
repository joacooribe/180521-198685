﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Repository
    {
        public ICollection<Colaborator> colaboratorCollection { get; }
        public ICollection<Administrator> administratorCollection { get; }
        public ICollection<Team> teamList { get; }
        public ICollection<Blackboard> blackboardColecction { get; }

        public Repository() {
            colaboratorCollection = new List<Colaborator>();
            administratorCollection = new List<Administrator>();
            teamList = new List<Team>();
            blackboardColecction = new List<Blackboard>();
        }
    }
}
