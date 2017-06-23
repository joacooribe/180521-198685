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

namespace Interface
{
    public partial class BlackboardUI : Form
    {
        private Instance instance;
        private Blackboard blackboard;
        public BlackboardUI(Blackboard blackboard)
        {
            instance = Instance.GetInstance;
            this.blackboard = blackboard;
            InitializeComponent();
        }

        private void BlackboardUI_Load(object sender, EventArgs e)
        {

        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {

        }
    }
}
