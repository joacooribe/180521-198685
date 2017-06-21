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
using Persistence;
using System.Globalization;

namespace Interface
{
    public partial class RankingAdminUI : Form
    {
        private Singleton instance;

        private List<Team> teams;

        private List<User> usersInTeam;
        public RankingAdminUI()
        {
            instance = Singleton.GetInstance;
            teams = new List<Team>();
            usersInTeam = new List<User>();
            
            InitializeComponent();
            InicializeList();
            LoadTeams();

        }
        private void InicializeList()
        {

            teams = new List<Team>();
            using (ContextDB context = new ContextDB())
            {
                teams = context.Teams.ToList();
            }
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

        private void LoadUsers(Team team)
        {
        }

        private void BtnSelectUser_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            this.Hide();
        }

        private void BtnResetRank_Click(object sender, EventArgs e)
        {

        }
    }
}
