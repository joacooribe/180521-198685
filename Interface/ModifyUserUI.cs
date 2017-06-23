using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using Exceptions;
using System.Globalization;

namespace Interface
{
    public partial class ModifyUserUI : UserControl
    {
        private Instance instance;
        private List<User> users { get; set; }
        public ModifyUserUI()
        {
            instance = Instance.GetInstance;
            InitializeComponent();
            LoadUserList();
            LoadUsersToDataGrid();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtActualPassword.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para cambiar su contraseña.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
                User user = (User)selectedUser;
                try
                {
                    instance.UserHandler.ModifyPassword(user.mail, txtNewPassword.Text);
                    MessageBox.Show("Modificación exitosa.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualPassword.Text = "";
                    txtNewPassword.Text = "";
                    LoadUserList();
                    LoadUsersToDataGrid();
                }
                catch (UserException ex)
                {
                    String msgError = ex.Message;
                    MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            List<User> allUsers = instance.UserHandler.LoadUsers();
            foreach (User user in allUsers)
            {
                if (user.active)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
            var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
            User user = (User)selectedUser;
            if (user.mail.Equals(instance.Session.user.mail))
            {
                MessageBox.Show("No puede eliminarse a usted mismo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Desea eliminar a " + user.mail + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    instance.UserHandler.DeleteUser(user.mail);
                    LoadUserList();
                    LoadUsersToDataGrid();
                }
            }
        }
    }
}
