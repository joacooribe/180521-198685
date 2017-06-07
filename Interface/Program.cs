using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence;
using System.Windows.Forms;

namespace Interface
{
    static class Program
    {
   
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Start start = new Interface.Start();

            start.Show();

            Application.Run(start);
        }
    }
}
