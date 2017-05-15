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
            InitializeComponent();
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

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
            string name = TxtName.ToString();
            string surname = TxtSurname.ToString();
            string mail = TxtEmail.ToString();
            string password = TxtPassword.ToString();
            DateTime birthdate = DTBirthdate.Value;
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
        }
    }
}
