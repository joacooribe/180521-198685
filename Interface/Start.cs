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
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnColabSession_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
    }
}
