using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Reflection.Emit;


namespace Ayan_Shukla_NEA
{
    public partial class LoginPage : Form
    {



        public LoginPage()
        {
            InitializeComponent();
        }


        private void LOGIN_Click(object sender, EventArgs e)
        {

            string hashedPassword = Compute(txtPassword.Text);
            string enteredUser = txtUser.Text;
            string enteredPass = txtPassword.Text;


            using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=NEA DB.db"))
            {
                myConnection.Open();


                string query = "SELECT COUNT(*) FROM NEA_LOGIN WHERE Username = @username AND PasswordHash = @password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@username", enteredUser);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);


                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Login successful
                        MessageBox.Show("Login successful!");
                        DiagnosticQuizPage DQPf = new DiagnosticQuizPage();
                        DQPf.Username = enteredUser;
                        DQPf.Show();

                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Incorrect login details, try again.");
                        txtUser.Clear();
                        txtPassword.Clear();
                        txtUser.Focus();
                    }
                }

                myConnection.Close();
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUser.Clear();
            txtUser.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static string Compute(string input)
        {
            unchecked
            {
                const uint FNV_OFFSET = 2166136261u;//Number to begin hash with
                const uint FNV_PRIME = 16777619u;//Number we multiply with
                uint hash = FNV_OFFSET;//Start hash with first number

                foreach (byte b in System.Text.Encoding.UTF8.GetBytes(input ?? ""))//Turn each input into bytes, if input is empty turn it into " "
                {
                    hash ^= b;//combines hash with bytes
                    hash *= FNV_PRIME;//mixes the hash more
                }

                return hash.ToString("x8");//convert 32bit value into hex
            }
        }
    }

}
