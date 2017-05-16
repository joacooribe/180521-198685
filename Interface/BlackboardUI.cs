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
using Persistence;
using Logic;

namespace Interface
{
    public partial class BlackboardUI : Form
    {
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public TeamHandler teamHandler { get; set; }
        public Repository repository { get; set; }
        public BlackboardHandler blackboardHandler { get; set; }
        public BlackboardUI(Session session, Repository repository)
        {
            InitializeComponent();
        }

        private void BlackboardUI_Load(object sender, EventArgs e)
        {

        }

        public void BlackboardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
