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
        private Singleton instance;

        private Blackboard blackboard;
        public BlackboardUI(Blackboard blackboard)
        {
            instance = Singleton.GetInstance;
            this.blackboard = blackboard;
            InitializeComponent();
        }

        private void BlackboardUI_Load(object sender, EventArgs e)
        {

        }
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void BlackboardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
