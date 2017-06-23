using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain;
using System.Globalization;

namespace Interface
{
    public partial class RankingAdminUI : Form
    {
        private Instance instance;
        private List<Team> teams;
        private List<User> usersInTeam;
        public RankingAdminUI()
        {
            instance = Instance.GetInstance;
            teams = new List<Team>();
            usersInTeam = new List<User>();
            InitializeComponent();
            InicializeList();
            LoadTeams();
        }
        private void InicializeList()
        {
            teams = instance.TeamHandler.LoadTeams();
        }

        private void LoadTeams()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.DataGridViewTeams.Rows.Clear();
            foreach (Team team in teams)
            {
                var rowIndex = this.DataGridViewTeams.Rows.Add(team.name, team.description);
                this.DataGridViewTeams.Rows[rowIndex].Tag = team;
            }
        }

        private void BtnSelectTeam_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
            Team team = (Team)selectedTeam;
            LblUserSelected.Text = team.name;
            LblUserSelected.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            this.Hide();
        }
    }
}
