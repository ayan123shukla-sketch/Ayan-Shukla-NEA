using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayan_Shukla_NEA
{
    public partial class DashboardPage : Form
    {
        public string Goal1 { get; set; }
        public string Frequency1 { get; set; }

        



        public DashboardPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new WorkoutsPage().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new DailyQuiz().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new WeeklyChallengesPage().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = Goal1;
            label8.Text = Frequency1;
            //label7.Text = "10";
            //label8.Text = "10";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
