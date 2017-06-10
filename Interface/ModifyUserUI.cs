using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Persistence;
using Logic;

namespace Interface
{
    public partial class ModifyUserUI : UserControl
    {
        private Singleton instance;
        public ModifyUserUI()
        {
            instance = Singleton.GetInstance;
            InitializeComponent();
        }

        private void ModifyUserUI_Load(object sender, EventArgs e)
        {

        }

      

        private void btnModify_Click(object sender, EventArgs e)
        {
            User user = instance.repository.session.user;
            if (user.password == txtActualPassword.Text)
            {
                try
                {
                    instance.colaboratorHandler.ModifyPassword(user.mail, txtNewPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contraseña nueva invalida, ingrese una correcta.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Contraseña actual invalida, ingrese nuevamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
