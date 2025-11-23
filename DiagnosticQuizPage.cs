using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ayan_Shukla_NEA
{
    
    public partial class DiagnosticQuizPage : Form
    {

        public string Username { get; set; }
        public DiagnosticQuizPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome to your Diagnostic Quiz " + Username;
        }

        private void DiagnosticQuiz_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get selected goal
            string goal = "";
            if (radioAthleticism.Checked) goal = "Athleticism or Agility";
            else if (radioBodyBuilding.Checked) goal = "BodyBuilding";
            else if (radioGeneralHealth.Checked) goal = "General Health";

            //MessageBox.Show(goal);

            // Get selected frequency
            string frequency = "";
            if (radio1to2.Checked) frequency = "1-2 Times per Week";
            else if (radio2to3.Checked) frequency = "2-3 Times per Week";
            else if (radio3to4.Checked) frequency = "3-4 Times per Week";
            //MessageBox.Show(frequency);

            // Check that both are selected
            if (string.IsNullOrEmpty(goal) || string.IsNullOrEmpty(frequency))
            {
                MessageBox.Show("Please select both your goal and frequency before submitting.");
                return;
            }

            //  SQLite database connection (local file)
            string connectionString = "Data Source=NEA DB.db;Version=3;";

            // Insert query
            string query = "INSERT INTO UserQuizResponses (Goal, Frequency) VALUES (@Goal, @Frequency)";

            // Execute insert
            // using (SQLiteConnection myConnection = new SQLiteConnection(connectionString))
            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=NEA DB.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@Goal", goal);
                    cmd.Parameters.AddWithValue("@Frequency", frequency);

                    try
                    {
                        myConnection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Response saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving data: " + ex.Message);
                    }
                }
            }
            string Goal2 = "0";
            string Frequency2 = "0";
            if (radioAthleticism.Checked) Goal2 = "Athleticism";//10
            else if (radioBodyBuilding.Checked) Goal2 = "BodyBuilding";//20
            else if (radioGeneralHealth.Checked) Goal2 = "GeneralHealth";//30

            if (radio1to2.Checked) Frequency2 = "1 - 2 Times per Week";
            else if (radio2to3.Checked) Frequency2 = "2 - 3 Times per Week";
            else if (radio3to4.Checked) Frequency2 = "3 - 4 Times per Week";

            DashboardPage dbpf = new DashboardPage();
            dbpf.Goal1 = Goal2;  
            dbpf.Frequency1 = Frequency2;  
            dbpf.Show();

            
            this.Hide();

        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
