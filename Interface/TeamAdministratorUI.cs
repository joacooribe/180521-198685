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
        public TeamAdministratorUI(Session session, Repository repository)
        {
            InitializeComponent();
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {

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
    }
}
