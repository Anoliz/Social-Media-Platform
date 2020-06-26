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
    public partial class News : Form
    {
        Connection_db con = new Connection_db();
        string id, username, post;
        public News(string username)
        {
            InitializeComponent();
            
            this.Text = username + " - SMP";
            this.username = username;
            reloadFeed();

        }

        private void News_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reloadFeed();
        }

        private void posttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void friendsbtn_Click(object sender, EventArgs e)
        {
            new Forms.Friends(username).Show();
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            try
            {


                    con.Open();
                    string query = "INSERT into posts (username,post) VALUES ('" +username+"','"+posttxt.Text+"')";
                    MySqlDataReader row;
                    if (posttxt.Text != "")
                    {
                        row = con.ExecuteReader(query);
                    }
                    else
                    {
                        MessageBox.Show("το Post δεν έγινε", "Information");
                    }

            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
        private void reloadFeed()
        {
            poststxt.Text = "";
            try
            {
                string post;
                string id;
                string date;


                    con.Open();
                    string query = "select id,username,post,date from posts WHERE username ='" + username +"'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["id"].ToString();
                            post = row["post"].ToString();
                            date = row["date"].ToString();
                            poststxt.Text = poststxt.Text +  post + " | "+ date + "\r\n\r\n";
                        }
                    }
                
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }
    }
}
