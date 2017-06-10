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
        private Singleton instance;

        private ColaboratorUI colabUI;
        public TeamUI(ColaboratorUI colabUI)
        {
            instance = Singleton.GetInstance;
            this.colabUI = colabUI;
            InitializeComponent();
            loadTeams();
        }

        private void loadTeams()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewTeam.Rows.Clear();
            foreach (Team team in instance.repository.teamCollection)
            {
                if (team.usersInTeam.Contains(instance.session.user)) {
                    var rowIndex = this.dataGridViewTeam.Rows.Add(team.name, team.description, team.maxUsers);
                    this.dataGridViewTeam.Rows[rowIndex].Tag = team;
                }
            }
        }

        private void TeamUI_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
