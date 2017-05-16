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
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        public TeamUI(Repository repository)
        {
            this.repository = repository;
            InitializeComponent();
            loadTeams();
        }

        private void loadTeams()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewTeam.Rows.Clear();
            foreach (Team team in repository.teamCollection)
            {
                var rowIndex = this.dataGridViewTeam.Rows.Add(team.name, team.description, team.maxUsers);
                this.dataGridViewTeam.Rows[rowIndex].Tag = team;
            }
        }

        private void TeamUI_Load(object sender, EventArgs e)
        {

        }
    }
}
