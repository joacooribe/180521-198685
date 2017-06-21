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
using System.Globalization;

namespace Interface
{
    public partial class ModifyUserUI : UserControl
    {
        private Singleton instance;
        private List<User> users { get; set; }

        public ModifyUserUI()
        {
            instance = Singleton.GetInstance;
            InitializeComponent();
            LoadUserList();
            LoadUsersToDataGrid();
        }

        private void ModifyUserUI_Load(object sender, EventArgs e)
        {

        }

      

        private void btnModify_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
            var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
            User user = (User)selectedUser;
                try
                {
                    instance.userHandler.ModifyPassword(user.mail, txtNewPassword.Text);
                    MessageBox.Show("Modificación exitosa.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualPassword.Text = "";
                    txtNewPassword.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Contraseña nueva invalida, ingrese una correcta.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
                User user = (User)selectedUser;
                txtActualPassword.Text = user.password;
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadUserList()
        {
            users = new List<User>();
            using (ContextDB context = new ContextDB())
            {
                foreach (User user in context.Users.ToList())
                {
                        users.Add(user);
                }

            }

        }
        private void LoadUsersToDataGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUsers.Rows.Clear();
            foreach (User user in users)
            {
                var rowIndex = this.dataGridViewUsers.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUsers.Rows[rowIndex].Tag = user;

            }
        }
    }
}
