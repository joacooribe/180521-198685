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
    public partial class ModifyUserUI : UserControl
    {
        public Session session { get; set; }
        public AdministratorHandler administratorHandler { get; set; }
        public ColaboratorHandler colaboratorHandler { get; set; }
        public Repository repository { get; set; }
        public ModifyUserUI()
        {

            InitializeComponent();
        }

        private void ModifyUserUI_Load(object sender, EventArgs e)
        {

        }

    }
}
