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
        private Singleton instance;
        public RegisterUI()
        {
            instance = Singleton.GetInstance;
            InitializeComponent();
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {
            
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
                    instance.administratorHandler.AddAdministrator(adminToAdd);
                }
                else if (RdoColaborator.Checked)
                {
                    Colaborator colabToAdd = new Colaborator();
                    colabToAdd.name = name;
                    colabToAdd.surname = surname;
                    colabToAdd.mail = mail;
                    colabToAdd.password = password;
                    colabToAdd.birthday = birthdate;
                    instance.colaboratorHandler.AddColaborator(colabToAdd);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
