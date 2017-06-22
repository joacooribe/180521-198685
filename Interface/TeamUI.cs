using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Persistence;
using Logic;
using System.Globalization;

namespace Interface
{
    public partial class TeamUI : UserControl
    {
        private Instance instance;
        List<Team> teams;
        private ColaboratorUI colabUI;
        public TeamUI(ColaboratorUI colabUI)
        {
            instance = Instance.GetInstance;
            this.colabUI = colabUI;
            InitializeComponent();
            loadTeams();
        }

        private void loadTeams()
        {
            teams = new List<Team>();
            using (ContextDB context = new ContextDB())
            {
                teams = context.Teams.ToList();
            }
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewTeam.Rows.Clear();
            foreach (Team team in teams)
            {
                var rowIndex = this.dataGridViewTeam.Rows.Add(team.name, team.description,team.maxUsers);
                this.dataGridViewTeam.Rows[rowIndex].Tag = team;
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewTeam.CurrentCell.RowIndex;
            var selectedTeam = this.dataGridViewTeam.Rows[selectedRow].Tag;
            TeamMenuUI teamMenuUI = new TeamMenuUI((Team)selectedTeam);
            colabUI.Hide();
            teamMenuUI.Show();
        }
    }
}
