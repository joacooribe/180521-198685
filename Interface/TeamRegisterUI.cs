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
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        public List<User> users { get; set; }
        public List<User> usersForTeam { get; set; }
        public TeamRegisterUI(Repository repository)
        {
            this.repository = repository;
            InitializeComponent();
            users = new List<User>();
            usersForTeam = new List<User>();
            InitializeList();
            loadUsers();
        }

        private void loadUsers()
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
            foreach(Administrator admin in repository.administratorCollection)
            {
                users.Add(admin);
            }
            foreach (Colaborator colaborator in repository.colaboratorCollection)
            {
                users.Add(colaborator);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI(this.session, this.repository);
            administratorUI.administratorHandler = this.administratorHandler;
            administratorUI.colaboratorHandler = this.colaboratorHandler;
            administratorUI.teamHandler = this.teamHandler;
            administratorUI.blackboardHandler = this.blackboardHandler;
            this.Hide();
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string name = txtTeamName.Text;
            string description = txtDescription.Text;
            int maxUsers = (int)nudMaxUsers.Value;
            User user = administratorHandler.GetUserFromColecction(this.repository.session.user.mail);
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
                this.teamHandler.AddTeam(teamToAdd);
                AdministratorUI administratorUI = new AdministratorUI(this.session, this.repository);
                administratorUI.administratorHandler = this.administratorHandler;
                administratorUI.colaboratorHandler = this.colaboratorHandler;
                administratorUI.teamHandler = this.teamHandler;
                administratorUI.blackboardHandler = this.blackboardHandler;
                this.Hide();
            }
            catch (TeamException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TeamRegisterUI_Load(object sender, EventArgs e)
        {
            
        }

        public void TeamRegisterUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblUserListInTeam_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listEmpty()
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
                loadUsers();
                reloadUsersForTeam();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No hay mas usuarios para agregar a la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void reloadUsersForTeam()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserForTeam.Rows.Clear();
            foreach (User user in usersForTeam)
            {
                var rowIndex = this.dataGridViewUserForTeam.Rows.Add(user.mail, user.name, user.surname);
                this.dataGridViewUserForTeam.Rows[rowIndex].Tag = user;
            }
        }
    }
}
