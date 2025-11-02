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


namespace Ayan_Shukla_NEA
{
    public partial class Form1 : Form
    {
       
    

        public Form1()
        {
            InitializeComponent();
        }


        private void LOGIN_Click(object sender, EventArgs e)
        {
            string hashedPassword = hash.ComputeSha256Hash(txtPassword.Text);
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
                        new Form2().Show();
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
    }
}
