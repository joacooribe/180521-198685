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
            User user = (User)instance.userHandler.GetUserFromColecction(instance.session.user.mail);
            List<Team> teamsBelongs = (List<Team>)instance.userHandler.GetTeams(user);
            foreach (Team team in teamsBelongs)
            {
                var rowIndex = this.DataGridViewTeamBelongs.Rows.Add(team.name, team.description);
                this.DataGridViewTeamBelongs.Rows[rowIndex].Tag = team;
            }
        }
        private void InitializeList()
        {
            teams = new List<Team>();
            using (ContextDB context = new ContextDB())
            {
                teams = context.Teams.ToList();
            }

        }
        private void BtnDeleteTeam_Click(object sender, EventArgs e)
        {
            try{
                var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
                var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
                Team teamToDel = (Team)selectedTeam;
                string nameTeam = teamToDel.name;
                instance.teamHandler.DeleteTeam(teamToDel);
                InitializeList();
                LoadTeams();
                LoadTeamBelongs();
                MessageBox.Show("Se ha eliminado el equipo: " + nameTeam, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeamBelongs.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeamBelongs.Rows[selectedRow].Tag;
            TeamMenuUI teamMenuUI = new TeamMenuUI((Team)selectedTeam);
            adminUI.Hide();
            teamMenuUI.Show();
        }

        private void BtnModifyTeam_Click(object sender, EventArgs e)
        {
            var selectedRow = this.DataGridViewTeams.CurrentCell.RowIndex;
            var selectedTeam = this.DataGridViewTeams.Rows[selectedRow].Tag;
            Team team = (Team)selectedTeam;
            team = instance.teamHandler.GetTeamFromCollection(team.name);
            ModifyTeamUI modifyTeamUI = new ModifyTeamUI(team);
            adminUI.Hide();
            modifyTeamUI.Show();
        }

    }
}
