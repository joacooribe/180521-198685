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
    class Singleton
    {
        private static Singleton instance;

        private static readonly object padlock = new object();

        public ContextDB contextDB { get; set; }

        public Repository repository { get; set; }

        public Session session { get; set; }

        public ISessionHandler sessionHandler { get; set; }

        public IAdministratorHandler administratorHandler { get; set; }

        public IColaboratorHandler colaboratorHandler { get; set; }

        public ITeamHandler teamHandler { get; set; }

        public IBlackboardHandler blackboardHandler { get; set; }

        public IAdministratorPersistance administratorPersistence { get; set; }

        public IColaboratorPersistance colaboratorPersistence { get; set; }

        public ITeamPersistance teamPersistence { get; set; }

        public IBlackboardPersistance blackboardPersistence { get; set; }

        private Singleton()
        {
            this.repository = Repository.GetInstance;

            this.contextDB = new ContextDB();

            this.session = new Session();

            this.sessionHandler = new SessionHandler();

            this.administratorPersistence = new AdministratorPersistenceHandler();

            this.colaboratorPersistence = new ColaboratorPersistenceHandler();

            this.teamPersistence = new TeamPersistenceHandler();

            this.blackboardPersistence = new BlackboardPersistenceHandler();

            this.administratorHandler = new AdministratorHandler();

            this.colaboratorHandler = new ColaboratorHandler();

            this.teamHandler = new TeamHandler();

            this.blackboardHandler = new BlackboardHandler();

        }

        public static Singleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
