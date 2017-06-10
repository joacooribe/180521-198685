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
        private Singleton instance;
        public ColaboratorUI()
        {
            instance = Singleton.GetInstance;
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
            Start start = new Start();
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
            TeamUI teamUi = new TeamUI(this);
            this.ColaboratorUIPanel.Controls.Clear();
            this.ColaboratorUIPanel.Controls.Add(teamUi);
        }

        private void ColaboratorUI_Load(object sender, EventArgs e)
        {
        }
        
    }
}
