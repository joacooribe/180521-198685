using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Logic;
using Persistence;


namespace Interface
{
    public partial class Start : Form
    {
        public Session session { get; set; }
        public Repository repository { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }

        public AdministratorPersistenceHandler administratorPersistence{get;set;}
        public ColaboratorPersistenceHandler colaboratorPersistence { get; set; }
        public TeamPersistenceHandler teamPersistence { get; set; }
        public BlackboardPersistenceHandler blackboardPersistence { get; set; }
        public Start()
        {
            this.repository = new Repository();
            repository.session = session;
            this.administratorPersistence = new AdministratorPersistenceHandler(this.repository);
            this.colaboratorPersistence = new ColaboratorPersistenceHandler(this.repository);
            this.teamPersistence = new TeamPersistenceHandler(this.repository);
            this.blackboardPersistence = new BlackboardPersistenceHandler(this.repository);

            this.administratorHandler = new AdministratorHandler() { administratorFunctions = administratorPersistence };
            this.colaboratorHandler = new ColaboratorHandler() { colaboratorFunctions = colaboratorPersistence };
            this.teamHandler = new TeamHandler() { teamFunctions = teamPersistence };
            this.blackboardHandler = new BlackboardHandler() { blackboardFunctions = blackboardPersistence };

            

            InitializeComponent();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string email = this.TxtEmail.Text;
            string password = this.TxtPassword.Text;
            if(RdoColaborator.Checked)
            {
                this.colaboratorHandler.LoginColaborator(email,password);
                ColaboratorUI colaboratorUI = new ColaboratorUI(this.session, this.repository);
                colaboratorUI.administratorHandler = this.administratorHandler;
                colaboratorUI.colaboratorHandler = this.colaboratorHandler;
                colaboratorUI.teamHandler = this.teamHandler;
                colaboratorUI.blackboardHandler = this.blackboardHandler;
                colaboratorUI.Show();

            }
            else if(RdoAdmin.Checked)
            {
                this.administratorHandler.LoginAdministrator(email, password);
                AdministratorUI administratorUI = new AdministratorUI(this.session, this.repository);
                administratorUI.administratorHandler = this.administratorHandler;
                administratorUI.colaboratorHandler = this.colaboratorHandler;
                administratorUI.teamHandler = this.teamHandler;
                administratorUI.blackboardHandler = this.blackboardHandler;
                administratorUI.Show();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Colaborator colaborator1 = new Colaborator();
            colaborator1.name = "Joaquin";
            colaborator1.surname = "Oribe";
            colaborator1.mail = "joaco@gmail.com";
            colaborator1.password = "joaquin1";
            colaborator1.birthday = new DateTime(1992, 9, 10);
            repository.colaboratorCollection.Add(colaborator1);
        }
    }
}
