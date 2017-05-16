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
using Exceptions;

namespace Interface
{
    public partial class Start : Form
    {
        ///public Session session { get; set; }
        public Repository repository { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }

        public AdministratorPersistenceHandler administratorPersistence{get;set;}
        public ColaboratorPersistenceHandler colaboratorPersistence { get; set; }
        public TeamPersistenceHandler teamPersistence { get; set; }
        public BlackboardPersistenceHandler blackboardPersistence { get; set; }
        public Start(Repository repository)
        {
            this.repository = repository;
            
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
            this.lblError.Text = "";
            string email = this.TxtEmail.Text;
            string password = this.TxtPassword.Text;
            try
            {
                if (RdoColaborator.Checked)
                {
                    this.colaboratorHandler.LoginColaborator(email, password);
                    ColaboratorUI colaboratorUI = new ColaboratorUI(this.repository.session, this.repository);
                    colaboratorUI.administratorHandler = this.administratorHandler;
                    colaboratorUI.colaboratorHandler = this.colaboratorHandler;
                    colaboratorUI.teamHandler = this.teamHandler;
                    colaboratorUI.blackboardHandler = this.blackboardHandler;
                    colaboratorUI.Show();
                    this.Hide();

                }
                else if (RdoAdmin.Checked)
                {
                    this.administratorHandler.LoginAdministrator(email, password);
                    AdministratorUI administratorUI = new AdministratorUI(this.repository.session, this.repository);
                    administratorUI.administratorHandler = this.administratorHandler;
                    administratorUI.colaboratorHandler = this.colaboratorHandler;
                    administratorUI.teamHandler = this.teamHandler;
                    administratorUI.blackboardHandler = this.blackboardHandler;
                    administratorUI.Show();
                    this.Hide();
                }
            }
            catch (UserException ex)
            {
                String msgError = ex.Message;
                this.lblError.Text = msgError;
                this.lblError.Visible = true;
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }

        public void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Colaborator colaborator1 = new Colaborator();
            colaborator1.name = "Colab";
            colaborator1.surname = "Orator";
            colaborator1.mail = "colab@gmail.com";
            colaborator1.password = "colaborator1";
            colaborator1.birthday = new DateTime(1992, 9, 10);
            repository.colaboratorCollection.Add(colaborator1);

            Administrator administrator1 = new Administrator();
            administrator1.name = "Admin";
            administrator1.surname = "Istrator";
            administrator1.mail = "admin@admin.com";
            administrator1.password = "administrator1";
            administrator1.birthday = new DateTime(1992, 9, 10);
            repository.administratorCollection.Add(administrator1);

            this.label5.Visible= true;
        }
    }
}
