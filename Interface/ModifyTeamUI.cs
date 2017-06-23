using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Domain;
using System.Globalization;

namespace Interface
{
    public partial class ModifyTeamUI : Form
    {

        private Instance instance;
        private List<User> users { get; set; }
        private List<User> usersInTeam { get; set; }
        private Team teamToModify { get; set; }
        public ModifyTeamUI(Team team)
        {
            instance = Instance.GetInstance;
            teamToModify = team;
            usersInTeam = new List<User>();
            InitializeComponent();
            LoadUserList();
            LoadUsersInTeamToDataGrid();
            LoadUsersToDataGrid();
            TxtName.Text = team.name;
            NudMaxUsers.Value = team.maxUsers;
            TxtDescription.Text = team.description;
        }

        private void LoadUserList()
        {
            users = new List<User>();
            foreach (User user in instance.TeamHandler.GetUsersFromTeam(teamToModify))
            {
                usersInTeam.Add(user);
            }
            List<User> allUsers = instance.UserHandler.LoadUsers();
            {
                foreach (User user in allUsers)
                {
                    if (!usersInTeam.Contains(user) && user.active)
                    {
                        users.Add(user);
                    }
                }
            }
        }

        private void LoadUsersToDataGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            dataGridViewUsers.Rows.Clear();
            foreach (User user in users)
            {
                var rowIndex = dataGridViewUsers.Rows.Add(user.mail, user.name, user.surname);
                dataGridViewUsers.Rows[rowIndex].Tag = user;
            }
        }
        private void LoadUsersInTeamToDataGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserInTeam.Rows.Clear();
            foreach (User user in usersInTeam)
            {
                var rowIndex = dataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                dataGridViewUserInTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void ReloadUsersInTeam()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserInTeam.Rows.Clear();
            foreach (User user in usersInTeam)
            {
                var rowIndex = dataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                dataGridViewUserInTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = dataGridViewUsers.Rows[selectedRow].Tag;
                usersInTeam.Add((User)selectedUser);
                users.Remove((User)selectedUser);
                LoadUsersToDataGrid();
                ReloadUsersInTeam();
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = this.dataGridViewUserInTeam.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUserInTeam.Rows[selectedRow].Tag;
                usersInTeam.Remove((User)selectedUser);
                users.Add((User)selectedUser);
                LoadUsersToDataGrid();
                ReloadUsersInTeam();
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string newDescription = TxtDescription.Text;
            int newMaxUsers = (int)NudMaxUsers.Value;
            try
            {
                instance.TeamHandler.ModifyTeamDescription(teamToModify.name, newDescription);
                instance.TeamHandler.ModifyTeamMaxUsers(teamToModify.name, newMaxUsers);
                instance.TeamHandler.ModifyTeamUsers(teamToModify,usersInTeam);
                AdministratorUI administratorUI = new AdministratorUI();
                MessageBox.Show("Equipo modificado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                administratorUI.Show();
                Hide();
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            Hide();
        }
    }
}
