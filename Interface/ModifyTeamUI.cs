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
using Logic;
using Persistence;
using Exceptions;
using System.Globalization;

namespace Interface
{
    public partial class ModifyTeamUI : Form
    {

        public AdministratorHandler administratorHandler { get; set; }

        public ColaboratorHandler colaboratorHandler { get; set; }

        public TeamHandler teamHandler { get; set; }

        public Repository repository { get; set; }

        public BlackboardHandler blackboardHandler { get; set; }

        private List<User> users { get; set; }

        private List<User> usersInTeam { get; set; }

        private Team team { get; set; }

        public ModifyTeamUI(Repository repository, Team team)
        {
            InitializeComponent();
        }

        private void ModifyTeamUI_Load(object sender, EventArgs e)
        {

        }
    }
}
