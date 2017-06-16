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
using System.Globalization;


namespace Interface
{
    public partial class TeamMenuUI : Form
    {
        private Singleton instance;

        private Team team { get; set; }

        private List<User> users { get; set; }

        public TeamMenuUI(Team team)
        {
            instance = Singleton.GetInstance;
            this.team = team;
            users = new List<User>();
            InitializeComponent();
            LoadBlackboardGrid();
            LoadUsers();
            LoadUsersGrid();

        }

        private void LoadBlackboardGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewBlackboard.Rows.Clear();
            foreach (Blackboard blackboard in instance.repository.blackboardCollection)
            {
                var rowIndex = this.dataGridViewBlackboard.Rows.Add(blackboard.name, blackboard.description);
                this.dataGridViewBlackboard.Rows[rowIndex].Tag = blackboard;
            }
        }

        private void LoadUsers()
        {
            foreach (Administrator admin in instance.repository.administratorCollection)
            {
                users.Add(admin);
            }
            foreach (Colaborator colaborator in instance.repository.colaboratorCollection)
            {
                users.Add(colaborator);
            }
        }

        private void LoadUsersGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewBlackboard.Rows.Clear();
            foreach (User user in team.usersInTeam)
            {
                var rowIndex = this.dataGridViewUsers.Rows.Add(user.name, user.surname, user.mail);
                this.dataGridViewUsers.Rows[rowIndex].Tag = user;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TeamMenuUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewBlackboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Type typeOfUser = instance.session.user.GetType();

            if (typeOfUser.Equals(typeof(Administrator)))
            {
                AdministratorUI administratorUI = new AdministratorUI();
                administratorUI.Show();
                this.Hide();
            }
            else
            {
                ColaboratorUI colaboratorUI = new ColaboratorUI();
                colaboratorUI.Show();
                this.Hide();
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewBlackboard.CurrentCell.RowIndex;
            var selectedBoard = this.dataGridViewBlackboard.Rows[selectedRow].Tag;
            try
            {
                Blackboard blackboard = (Blackboard)selectedBoard;
                Type typeOfUser = instance.session.user.GetType();
                if (blackboard.userCreator.Equals(instance.session) || typeOfUser.Equals(typeof(Administrator)))
                {
                   //delete blackboard.
                }
                else
                {
                    MessageBox.Show("No tiene autorización para borrar este pizarrón.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewBlackboard.CurrentCell.RowIndex;
            var selectedBoard = this.dataGridViewBlackboard.Rows[selectedRow].Tag;
            try
            {
                BlackboardUI blackboardUI = new BlackboardUI((Blackboard)selectedBoard);
                blackboardUI.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
