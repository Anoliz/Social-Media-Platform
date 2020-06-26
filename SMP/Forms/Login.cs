using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SMP
{
    public partial class Login : Form
    {

        Connection_db con = new Connection_db();
        string id, username, password;

        private void registerlbl_Click(object sender, EventArgs e)
        {
            new Forms.Register().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    con.Open();
                    string query = "select id,username,password from user WHERE username ='" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                        }

                        MessageBox.Show("Συνδέθηκες επιτυχώς " + username );
                        new Forms.News(username).Show();
                    }
                    else
                    {
                        MessageBox.Show("Δεν βρέθηκε ο χρήστης", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Δεν εγραψες το username η το password", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }

        }
    }
    }

