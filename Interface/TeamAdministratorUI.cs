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
    public partial class TeamAdministratorUI : UserControl
    {
        private Singleton instance;
        private List<Team> teams { get; set; }

        private AdministratorUI adminUI;
        public TeamAdministratorUI(AdministratorUI adminUI)
        {
            instance = Singleton.GetInstance;
            this.adminUI = adminUI;
            InitializeComponent();
            teams = new List<Team>();
            InitializeList();
            LoadTeams();
            LoadTeamBelongs();
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamRegisterUI teamRegister = new TeamRegisterUI();
            adminUI.Hide();
            teamRegister.Show();
            
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
        private void LoadTeamBelongs()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.DataGridViewTeamBelongs.Rows.Clear();
            foreach (Team team in teams)
            {
                if (team.usersInTeam.Contains(instance.repository.session.user)) {
                    var rowIndex = this.DataGridViewTeamBelongs.Rows.Add(team.name, team.description);
                    this.DataGridViewTeamBelongs.Rows[rowIndex].Tag = team;
                }
            }
        }
        private void InitializeList()
        {
            foreach (Team team in instance.repository.teamCollection)
            {
                teams.Add(team);
            }
           
        }
        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
            TeamMenuUI teamMenuUI = new TeamMenuUI((Team)selectedTeam);
            adminUI.Hide();
            teamMenuUI.Show();
        }

        private void BtnModifyTeam_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
            ModifyTeamUI modifyTeamUI = new ModifyTeamUI((Team)selectedTeam);
            adminUI.Hide();
            modifyTeamUI.Show();
        }

        private void TeamAdministratorUI_Load(object sender, EventArgs e)
        {

        }

        private void TblTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
