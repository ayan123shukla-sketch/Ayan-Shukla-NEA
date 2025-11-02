using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Ayan_Shukla_NEA
{
    public partial class Registration : Form
    {


       

        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            //string hashedPassword = ComputeSha256Hash(RUser.Text);
            string hashedPassword = hash.ComputeSha256Hash(RPassword.Text);
            string DRName = Regname.Text;
            string DRUser = RUser.Text;
            //string DRPassword = RPassword.Text;
            int DRAge = int.Parse(RAge.Text);

            //link database
            SQLiteConnection myConnection;
            myConnection = new SQLiteConnection("Data Source=NEA DB.db");
            //write query
            myConnection.Open();
            string query = "INSERT INTO NEA_LOGIN(Username, PasswordHash, name, Age) VALUES(@Username, @PasswordHash, @name, @Age)";

            SQLiteCommand myCommand = new SQLiteCommand (query,myConnection);

            // Add parameter values
            myCommand.Parameters.AddWithValue("@Username", DRUser);
            myCommand.Parameters.AddWithValue("@PasswordHash", hashedPassword);
            myCommand.Parameters.AddWithValue("@name", DRName);
            myCommand.Parameters.AddWithValue("@Age",DRAge);

            myCommand.ExecuteNonQuery();
                //execute commands
               
                myConnection.Close();

            Console.WriteLine("Well done you have registered succesfully");
            this.Hide();
            new Form1().Show();
        }
    }
}
