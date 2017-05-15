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
            Start start = new Start();
            start.administratorHandler = this.administratorHandler;
            start.colaboratorHandler = this.colaboratorHandler;
            start.teamHandler = this.teamHandler;
            start.blackboardHandler = this.blackboardHandler;

            this.session.user = null;
            start.session = this.session;
            this.Hide();
            start.Show();
        }
    }
}
