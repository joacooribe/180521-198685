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

        public ContextDB ContextDB { get; set; }

        public Repository Repository { get; set; }

        public Session Session { get; set; }

        public ISessionHandler SessionHandler { get; set; }

        public IAdministratorHandler AdministratorHandler { get; set; }

        public IColaboratorHandler ColaboratorHandler { get; set; }

        public ITeamHandler TeamHandler { get; set; }

        public IBlackboardHandler BlackboardHandler { get; set; }

        public ITeamPersistance TeamPersistence { get; set; }

        public IBlackboardPersistance BlackboardPersistence { get; set; }

        public IUserHandler UserHandler { get; set; }

        private Instance()
        {
            this.Repository = Repository.GetInstance;

            this.ContextDB = new ContextDB();

            this.Session = new Session();

            this.SessionHandler = new SessionHandler();

            this.TeamPersistence = new TeamPersistenceHandler();

            this.BlackboardPersistence = new BlackboardPersistenceHandler();

            this.AdministratorHandler = new AdministratorHandler();

            this.ColaboratorHandler = new ColaboratorHandler();

            this.TeamHandler = new TeamHandler();

            this.BlackboardHandler = new BlackboardHandler();

            this.UserHandler = new UserHandler();
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
