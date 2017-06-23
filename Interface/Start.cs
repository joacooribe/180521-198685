using System;
using System.Windows.Forms;
using Exceptions;

namespace Interface
{
    public partial class Start : Form
    {
        private Instance instance;

        public Start()
        {
            this.instance = Instance.GetInstance;
            InitializeComponent();
        }


        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string email = this.TxtEmail.Text;
            string password = this.TxtPassword.Text;
            try
            {
                if (RdoColaborator.Checked)
                {
                    instance.Session = instance.SessionHandler.LogInColaborator(email, password);
                    ColaboratorUI colaboratorUI = new ColaboratorUI();
                    colaboratorUI.Show();
                    this.Hide();
                }
                else if (RdoAdmin.Checked)
                {
                    instance.Session = instance.SessionHandler.LogInAdministrator(email, password);
                    AdministratorUI administratorUI = new AdministratorUI();
                    administratorUI.Show();
                    this.Hide();
                }
            }
            catch (UserException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
