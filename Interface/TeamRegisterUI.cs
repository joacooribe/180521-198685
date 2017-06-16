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
    public partial class TeamRegisterUI : Form
    {
        private Singleton instance;
        public List<User> users { get; set; }
        public List<User> usersForTeam { get; set; }
        public TeamRegisterUI()
        {
            instance = Singleton.GetInstance;
            InitializeComponent();
            users = new List<User>();
            usersForTeam = new List<User>();
            InitializeList();
            LoadUsers();
            
        }

        private void LoadUsers()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUsers.Rows.Clear();
            foreach (User user in users)
            {
                var rowIndex = this.dataGridViewUsers.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUsers.Rows[rowIndex].Tag = user;
            }
        }
        private void InitializeList()
        {

            using (ContextDB context = new ContextDB())
            {
                users = context.Users.ToList();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string name = txtTeamName.Text;
            string description = txtDescription.Text;
            int maxUsers = (int)nudMaxUsers.Value;
            User user = instance.administratorHandler.GetUserFromColecction(instance.session.user.mail);
            Administrator adminCreator = (Administrator)user;
            DateTime birthdate = DateTime.Now;
            try
            {
                Team teamToAdd = new Team();
                teamToAdd.name = name;
                teamToAdd.description = description;
                teamToAdd.maxUsers = maxUsers;
                teamToAdd.creator = adminCreator;
                teamToAdd.creationDate = birthdate;
                teamToAdd.usersInTeam = usersForTeam;
                instance.teamHandler.AddTeam(teamToAdd);
                AdministratorUI administratorUI = new AdministratorUI();
                administratorUI.Show();
                this.Hide();
            }
            catch (TeamException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TeamRegisterUI_Load(object sender, EventArgs e)
        {
            
        }


        private void lblUserListInTeam_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = this.dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUsers.Rows[selectedRow].Tag;
                usersForTeam.Add((User)selectedUser);
                users.Remove((User)selectedUser);
                LoadUsers();
                ReloadUsersForTeam();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay mas usuarios para agregar a la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ReloadUsersForTeam()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserForTeam.Rows.Clear();
            foreach (User user in usersForTeam)
            {
                var rowIndex = this.dataGridViewUserForTeam.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUserForTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = this.dataGridViewUserForTeam.CurrentCell.RowIndex;
                var selectedUser = this.dataGridViewUserForTeam.Rows[selectedRow].Tag;
                usersForTeam.Remove((User)selectedUser);
                users.Add((User)selectedUser);
                LoadUsers();
                ReloadUsersForTeam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede quitar mas usuarios del equipo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
