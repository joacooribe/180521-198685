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
using System.Globalization;

namespace Interface
{
    public partial class ModifyTeamUI : Form
    {

        private Singleton instance;

        private List<User> users { get; set; }

        private List<User> usersInTeam { get; set; }

        private Team team { get; set; }

        public ModifyTeamUI(Team team)
        {
            instance = Singleton.GetInstance;
            this.team = team;
            users = new List<User>();
            usersInTeam = new List<User>();
            InitializeComponent();
            LoadUserList();
            LoadUsersInTeamToDataGrid();
            LoadUsersToDataGrid();
            TxtName.Text =team.name;
            TxtDescription.Text = team.description;
            
        }

        private void LoadUserList()
        {
            foreach (Administrator admin in instance.repository.administratorCollection)
            {
                if (!team.usersInTeam.Contains(admin))
                {
                    users.Add(admin);
                }
            }
            foreach (Colaborator colaborator in instance.repository.colaboratorCollection)
            {
                if (!team.usersInTeam.Contains(colaborator))
                {
                    users.Add(colaborator);
                }
            }
            foreach (User user in team.usersInTeam)
            {
                usersInTeam.Add(user);
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
        private void LoadUsersInTeamToDataGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserInTeam.Rows.Clear();
            foreach (User user in usersInTeam)
            {
                var rowIndex = this.dataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUsers.Rows[rowIndex].Tag = user;
            }
        }
        
        private void ReloadUsersInTeam()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserInTeam.Rows.Clear();
            foreach (User user in usersInTeam)
            {
                var rowIndex = this.dataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUserInTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void ModifyTeamUI_Load(object sender, EventArgs e)
        {

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
                usersInTeam.Add((User)selectedUser);
                users.Remove((User)selectedUser);
                LoadUsersToDataGrid();
                ReloadUsersInTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay mas usuarios para agregar a la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("No puede quitar mas usuarios del equipo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string newDescription = TxtDescription.Text;
            int newMaxUsers = (int)NudMaxUsers.Value;
            try
            {
                instance.teamHandler.ModifyDescription(team.name, newDescription);
                instance.teamHandler.ModifyMaxUsers(team.name, newMaxUsers);
                AdministratorUI administratorUI = new AdministratorUI();
                MessageBox.Show("Equipo modificado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                administratorUI.Show();
                this.Hide();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            this.Hide();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
