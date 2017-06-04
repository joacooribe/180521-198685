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
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        private List<Team> teams { get; set; }
        public TeamAdministratorUI(Session session, Repository repository)
        {
            this.repository = repository;
            InitializeComponent();
            teams = new List<Team>();
            InitializeList();
            LoadTeams();
            LoadTeamBelongs();
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamRegisterUI teamRegister = new TeamRegisterUI(this.repository);
            teamRegister.administratorHandler = this.administratorHandler;
            teamRegister.colaboratorHandler = this.colaboratorHandler;
            teamRegister.teamHandler = this.teamHandler;
            teamRegister.blackboardHandler = this.blackboardHandler;
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
                if (team.usersInTeam.Contains(repository.session.user)) {
                    var rowIndex = this.DataGridViewTeamBelongs.Rows.Add(team.name, team.description);
                    this.DataGridViewTeamBelongs.Rows[rowIndex].Tag = team;
                }
            }
        }
        private void InitializeList()
        {
            foreach (Team team in repository.teamCollection)
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

        }

        private void BtnModifyTeam_Click(object sender, EventArgs e)
        {

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
