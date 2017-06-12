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
    public partial class RanksUI : Form
    {
        private Singleton instance;

        private List<Team> teams;

        private List<User> usersInTeam;
        public RanksUI()
        {
            instance = Singleton.GetInstance;
            teams = new List<Team>();
            usersInTeam = new List<User>();
            InitializeComponent();
            InitializeList();
            LoadTeamGrid();
        }

       private void InitializeList()
        {
            foreach (Team team in instance.repository.teamCollection)
            {
                teams.Add(team);
            }
        }
        
      private void LoadTeamGrid()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.DataGridViewTeams.Rows.Clear();
            foreach (Team team in teams)
            {
                var rowIndex = this.DataGridViewTeams.Rows.Add(team.name, team.description);
                this.DataGridViewTeams.Rows[rowIndex].Tag = team;
            }
        } 

      private void LoadUserGrid(Team team)
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.DataGridViewUserInTeam.Rows.Clear();
            foreach (User user in team.usersInTeam)
            {
                var rowIndex = this.DataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                this.DataGridViewUserInTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void BtnSelectTeam_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
            LoadUserGrid((Team)selectedTeam);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
        }
    }
}
