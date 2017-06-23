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
        private static Repository Instance;
        public ICollection<Colaborator> ColaboratorCollection;
        public ICollection<Administrator> AdministratorCollection;
        public ICollection<Team> TeamCollection;
        public ICollection<Blackboard> BlackboardCollection;
        private int idElement;
        
        private Repository() {
            ColaboratorCollection = new List<Colaborator>();
            AdministratorCollection = new List<Administrator>();
            TeamCollection = new List<Team>();
            BlackboardCollection = new List<Blackboard>();
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
                    if (Instance == null)
                    {
                        Instance = new Repository();
                    }
                    return Instance;
                }
            }
        }
    }
}
