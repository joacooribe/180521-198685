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
using Persistence;
using Logic;
using Exceptions;

namespace Interface
{
    public partial class RegisterUI : Form
    {
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }

        public RegisterUI(Session session, Repository repository)
        {
            this.repository = repository;
            InitializeComponent();
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {
            
        }

        public void RegisterUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            AdministratorUI administratorUI = new AdministratorUI(this.session, this.repository);
            administratorUI.administratorHandler = this.administratorHandler;
            administratorUI.colaboratorHandler = this.colaboratorHandler;
            administratorUI.teamHandler = this.teamHandler;
            administratorUI.blackboardHandler = this.blackboardHandler;
            this.Hide();
            administratorUI.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string surname = TxtSurname.Text;
            string mail = TxtEmail.Text;
            string password = TxtPassword.Text;
            DateTime birthdate = DTBirthdate.Value;
            try
            {
                if (RdoAdmin.Checked)
                {
                    Administrator adminToAdd = new Administrator();
                    adminToAdd.name = name;
                    adminToAdd.surname = surname;
                    adminToAdd.mail = mail;
                    adminToAdd.password = password;
                    adminToAdd.birthday = birthdate;
                    this.administratorHandler.AddAdministrator(adminToAdd);
                }
                else if (RdoColaborator.Checked)
                {
                    Colaborator colabToAdd = new Colaborator();
                    colabToAdd.name = name;
                    colabToAdd.surname = surname;
                    colabToAdd.mail = mail;
                    colabToAdd.password = password;
                    colabToAdd.birthday = birthdate;
                    this.colaboratorHandler.AddColaborator(colabToAdd);
                }
                AdministratorUI administratorUI = new AdministratorUI(this.session, this.repository);
                administratorUI.administratorHandler = this.administratorHandler;
                administratorUI.colaboratorHandler = this.colaboratorHandler;
                administratorUI.teamHandler = this.teamHandler;
                administratorUI.blackboardHandler = this.blackboardHandler;
                this.Hide();
                administratorUI.Show();
            }
            catch (UserException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
