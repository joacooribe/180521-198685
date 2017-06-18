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
        private Singleton instance;
        public AdministratorUI()
        {

            this.instance = Singleton.GetInstance;
            InitializeComponent();
            GenerateTeamsPanel();
        }

        private void AdministratorUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
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
            GenerateTeamsPanel();
        }
        
        private void GenerateTeamsPanel()
        {
            this.panel1.Controls.Clear();

            TeamAdministratorUI teamUI = new TeamAdministratorUI(this);

            this.panel1.Controls.Add(teamUI);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterUI registerUI = new RegisterUI();


            registerUI.Show();
            this.Hide();
        }

        private void BtnRankUser_Click(object sender, EventArgs e)
        {
            RankingAdminUI rankingAdminUI = new RankingAdminUI();
            rankingAdminUI.Show();
            this.Hide();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ModifyUserUI modifyUserUI = new ModifyUserUI();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(modifyUserUI);
        }
    }
}
