using System;
using System.Windows.Forms;
using Domain;
using Exceptions;

namespace Interface
{
    public partial class RegisterUI : Form
    {
        private Instance instance;
        public RegisterUI()
        {
            instance = Instance.GetInstance;
            InitializeComponent();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        { 
            AdministratorUI administratorUI = new AdministratorUI();
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
                    instance.AdministratorHandler.AddAdministrator(adminToAdd);
                }
                else if (RdoColaborator.Checked)
                {
                    Colaborator colabToAdd = new Colaborator();
                    colabToAdd.name = name;
                    colabToAdd.surname = surname;
                    colabToAdd.mail = mail;
                    colabToAdd.password = password;
                    colabToAdd.birthday = birthdate;
                    instance.ColaboratorHandler.AddColaborator(colabToAdd);
                }
                AdministratorUI administratorUI = new AdministratorUI();
                this.Hide();
                administratorUI.Show();
            }
            catch (UserException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
