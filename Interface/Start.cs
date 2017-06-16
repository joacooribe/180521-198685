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
        private Singleton instance;

        public Start()
        {
            this.instance = Singleton.GetInstance;

                    
            InitializeComponent();

            TxtEmail.Text = "admin@admin.com";

            TxtPassword.Text = "a11111";
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
                    instance.session = instance.sessionHandler.LogInColaborator(email, password);
                    ColaboratorUI colaboratorUI = new ColaboratorUI();
                    colaboratorUI.Show();
                    this.Hide();

                }
                else if (RdoAdmin.Checked)
                {
                    instance.session = instance.sessionHandler.LogInAdministrator(email, password);
                    AdministratorUI administratorUI = new AdministratorUI();
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
          

            this.label5.Visible= true;
            lblGenerate.Visible = false;
            BtnGenerate.Visible = false;
        }

        private void BtnClearDB_Click(object sender, EventArgs e)
        {
            this.instance.contextDB.EmptyTable();
        }
    }
}
