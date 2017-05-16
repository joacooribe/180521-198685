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
    public partial class ColaboratorUI : Form
    {
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        public ColaboratorUI(Session session,Repository repository)
        {
            this.repository = repository;
            InitializeComponent();

        }

        private void ColaboratorUIPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ColaboratorUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Start start = new Start(this.repository);
            start.administratorHandler = this.administratorHandler;
            start.colaboratorHandler = this.colaboratorHandler;
            start.teamHandler = this.teamHandler;
            start.blackboardHandler = this.blackboardHandler;

         
            start.repository.session = this.repository.session;
            this.Hide();
            start.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            this.ColaboratorUIPanel.Controls.Clear();
            this. ColaboratorUIPanel.Controls.Add(new ModifyUserUI());
          


        }

        private void BtnTeams_Click(object sender, EventArgs e)
        {
            TeamUI teamUi = new TeamUI(this.repository);
            teamUi.administratorHandler = this.administratorHandler;
            teamUi.colaboratorHandler = this.colaboratorHandler;
            teamUi.teamHandler = this.teamHandler;
            teamUi.blackboardHandler = this.blackboardHandler;
            this.ColaboratorUIPanel.Controls.Clear();
            this.ColaboratorUIPanel.Controls.Add(new TeamUI(repository));
        }

        private void ColaboratorUI_Load(object sender, EventArgs e)
        {
        }
    }
}
