using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayan_Shukla_NEA
{
    public partial class WorkoutsPage : Form
    {
        public WorkoutsPage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DashboardPage().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new WeeklyChallengesPage().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void WorkoutsPage_Load(object sender, EventArgs e)
        {
 
        }
    }
}
