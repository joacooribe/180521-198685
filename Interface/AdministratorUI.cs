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

namespace Interface
{
    public partial class AdministratorUI : Form
    {
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        public AdministratorUI(Session session, Repository repository)
        {
            this.session = session;
            this.repository = repository;
            InitializeComponent();
        }

        private void AdministratorUI_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Start start = new Start(this.repository);
            start.administratorHandler = this.administratorHandler;
            start.colaboratorHandler = this.colaboratorHandler;
            start.teamHandler = this.teamHandler;
            start.blackboardHandler = this.blackboardHandler;

            this.session.user = null;
            start.repository.session = this.session;
            this.Hide();
            start.Show();
        }

        private void BtnTeams_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new TeamAdministratorUI(session, repository));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterUI registerUI = new RegisterUI(this.repository.session,this.repository);
            registerUI.administratorHandler = this.administratorHandler;
            registerUI.colaboratorHandler = this.colaboratorHandler;
            registerUI.teamHandler = this.teamHandler;
            registerUI.blackboardHandler = this.blackboardHandler;
            registerUI.Show();
            this.Hide();
        }
    }
}
