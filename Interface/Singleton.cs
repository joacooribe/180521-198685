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

        public Repository repository { get; set; }

        public AdministratorHandler administratorHandler { get; set; }

        public ColaboratorHandler colaboratorHandler { get; set; }

        public TeamHandler teamHandler { get; set; }

        public BlackboardHandler blackboardHandler { get; set; }

        public AdministratorPersistenceHandler administratorPersistence { get; set; }

        public ColaboratorPersistenceHandler colaboratorPersistence { get; set; }

        public TeamPersistenceHandler teamPersistence { get; set; }

        public BlackboardPersistenceHandler blackboardPersistence { get; set; }

        private Singleton()
        {
            repository = new Repository();

            this.administratorPersistence = new AdministratorPersistenceHandler(repository);

            this.colaboratorPersistence = new ColaboratorPersistenceHandler(repository);

            this.teamPersistence = new TeamPersistenceHandler(repository);

            this.blackboardPersistence = new BlackboardPersistenceHandler(repository);

            this.administratorHandler = new AdministratorHandler() { administratorFunctions = administratorPersistence };

            this.colaboratorHandler = new ColaboratorHandler() { colaboratorFunctions = colaboratorPersistence };

            this.teamHandler = new TeamHandler() { teamFunctions = teamPersistence };

            this.blackboardHandler = new BlackboardHandler() { blackboardFunctions = blackboardPersistence };

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
