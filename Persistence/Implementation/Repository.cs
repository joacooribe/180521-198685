using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Repository
    {
        private static readonly object padlock = new object();
        private static Repository instance;
        public ICollection<Colaborator> colaboratorCollection { get; }
        public ICollection<Administrator> administratorCollection { get; }
        public ICollection<Team> teamCollection { get; }
        public ICollection<Blackboard> blackboardCollection { get; }
        private int idElement;
        
        private Repository() {
            colaboratorCollection = new List<Colaborator>();
            administratorCollection = new List<Administrator>();
            teamCollection = new List<Team>();
            blackboardCollection = new List<Blackboard>();
            idElement = 0;
        }

        public int AsignNumberToElement()
        {
            idElement++;
            int number = idElement;
            return number;
        }

        public static Repository GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Repository();
                    }
                    return instance;
                }
            }
        }
    }
}
