using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Logic;
using Persistence;

namespace Interface
{
    class Instance
    {
        private static Instance instance;
        private static readonly object padlock = new object();
        public ContextDB contextDB { get; set; }
        public Session Session { get; set; }
        public ISessionHandler SessionHandler { get; set; }
        public IAdministratorHandler AdministratorHandler { get; set; }
        public IColaboratorHandler ColaboratorHandler { get; set; }
        public ITeamHandler TeamHandler { get; set; }
        public IBlackboardHandler BlackboardHandler { get; set; }
        public IUserHandler UserHandler { get; set; }

        private Instance()
        {
            contextDB = new ContextDB();
            Session = new Session();
            SessionHandler = new SessionHandler();
            AdministratorHandler = new AdministratorHandler();
            ColaboratorHandler = new ColaboratorHandler();
            TeamHandler = new TeamHandler();
            BlackboardHandler = new BlackboardHandler();
            UserHandler = new UserHandler();
        }

        public static Instance GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Instance();
                    }
                    return instance;
                }
            }
        }
    }
}
