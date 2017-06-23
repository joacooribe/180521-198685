using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class ColaboratorUI : Form
    {
        private Instance instance;
        public ColaboratorUI()
        {
            instance = Instance.GetInstance;
            InitializeComponent();
            TeamUI teamUi = new TeamUI(this);
            this.ColaboratorUIPanel.Controls.Clear();
            this.ColaboratorUIPanel.Controls.Add(teamUi);
        }

        public void ColaboratorUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            this.Hide();
            start.Show();
        }

        private void BtnTeams_Click(object sender, EventArgs e)
        {
            TeamUI teamUi = new TeamUI(this);
            this.ColaboratorUIPanel.Controls.Clear();
            this.ColaboratorUIPanel.Controls.Add(teamUi);
        }
    }
}
