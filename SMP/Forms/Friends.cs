using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SMP.Forms
{
    
    public partial class Friends : Form
    {
        int found = 0;
        int leitourgeia = 0;
        string username;
        Connection_db con = new Connection_db();

        public Friends(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Friends_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            // ψαχνει να βρει εαν υπαρχει το username που θελεις να κανεις add, και αν υπαρχει, τοτε κανει add
            found = 0;
            leitourgeia = 4;
            string ss = "select id,username from user WHERE username ='" + addtxt.Text + "'";
            mysqlcommands(ss);


            // κανει αδδ εφοσων το found==1;
            if (addtxt.Text != username)
            {
                if (found == 1)
                {
                    ss = "INSERT into friends (name1,name2) VALUES ('" + username + "','" + addtxt.Text + "')";
                    mysqlcommands(ss);
                }
                else
                {
                    MessageBox.Show("Δεν υπάρχει ο χρήστης", "Information");
                }
            }
            else
            {
                MessageBox.Show("Δεν μπορείς να κάνεις add τον εαυτό σου", "Information");
            }
            found = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reloadFriends();
        }

        void reloadFriends()
        {
            //here is the reload of the friend requests
            friendrequests.Text = "";
            leitourgeia = 1;
            string command = "select id,name1,name2 from friends WHERE name2 ='" + username + "' AND status='0'";
            mysqlcommands(command);
            //here is the reload of friends
            friendstxt.Text = "";
            leitourgeia = 2;
            command = "select id,name1,name2 from friends WHERE name2 ='" + username + "' AND status='1'";
            mysqlcommands(command);
            leitourgeia = 3;
            command = "select id,name1,name2 from friends WHERE name1 ='" + username + "' AND status='1'";
            mysqlcommands(command);
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            leitourgeia = 0;
            string command = "update friends set status = 1 where name2 ='" + username + "' and name1 = '" + accepttxt.Text + "'";
            mysqlcommands(command);
        }


        public void mysqlcommands(string command)
        {
            try
            {


                con.Open();
                string query = command;
                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        if (leitourgeia == 1)
                        {
                            string friendrequestname;
                            friendrequestname = row["name1"].ToString();
                            friendrequests.Text = friendrequests.Text + friendrequestname + "  \r\n\r";
                        }
                        else if (leitourgeia == 2)
                        {
                            string friendname;
                            friendname = row["name1"].ToString();
                            friendstxt.Text = friendstxt.Text + friendname + "  \r\n\r";
                        }
                        else if (leitourgeia == 3)
                        {
                            string friendname;
                            friendname = row["name2"].ToString();
                            friendstxt.Text = friendstxt.Text + friendname + "  \r\n\r";
                        }
                        else if (leitourgeia == 4)
                        {
                            found = 1;
                        }
                    }
                }
                leitourgeia = 0;

            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string command ="DELETE FROM friends WHERE name1 = '" + username + "' and name2 = '" + deletetxt.Text + "'";
            mysqlcommands(command);
            command = "DELETE FROM friends WHERE name2 = '" + username + "' and name1 = '" + deletetxt.Text + "'";
            mysqlcommands(command);
        }
    }
    
}
