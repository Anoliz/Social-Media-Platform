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

namespace SMP.Forms
{
    public partial class Register : Form
    {
        Connection_db con = new Connection_db();
        string id, username, password;

        private void Register_Load(object sender, EventArgs e)
        {

        }

        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            int elegxosgiatousername = 0;

            //elegxei ean yparxei hdh afto to username, ean nai kanei tin panw metavliti = 1;
            try
            {
                    con.Open();
                    string query = "select id,username,password from user WHERE username ='" + textBox1.Text + "'";
                MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {

                        elegxosgiatousername = 1;
                    }
            }
            catch
            {
            }



            if (elegxosgiatousername == 0)
            {
                try
                {

                    if (textBox1.Text != "" && textBox2.Text != "")
                    {

                        con.Open();
                        string query = "INSERT into user (username,password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                        MySqlDataReader row;
                        row = con.ExecuteReader(query);
                        MessageBox.Show("Εκανες τον λογαριασμό επιτυχώς!", "Information");
                        if (row.HasRows)
                        {

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
            else {
                MessageBox.Show("Υπάρχει ήδη αυτο το username ", "Information");
            }
        }
    }
}
