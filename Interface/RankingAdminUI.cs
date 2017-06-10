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
    public partial class RankingAdminUI : Form
    {
        private Singleton instance;

        private List<Team> teams;

        private List<User> usersInTeam;

        private User userToRank;
        public RankingAdminUI()
        {
            instance = Singleton.GetInstance;
            teams = new List<Team>();
            usersInTeam = new List<User>();
            InicializeList();
            InitializeComponent();
            LoadTeams();

        }
        private void InicializeList()
        {
            foreach (Team team in instance.repository.teamCollection)
            {
                teams.Add(team);
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
            LoadUsers((Team)selectedTeam);
        }

        private void LoadUsers(Team team)
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.DataGridViewUserInTeam.Rows.Clear();
            foreach (User user in team.usersInTeam)
            {
                var rowIndex = this.DataGridViewUserInTeam.Rows.Add(user.mail, user.name, user.surname);
                this.DataGridViewUserInTeam.Rows[rowIndex].Tag = team;
            }
        }

    }
}
