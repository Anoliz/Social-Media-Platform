namespace SMP.Forms
{
    partial class Friends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.friendrequests = new System.Windows.Forms.TextBox();
            this.friendstxt = new System.Windows.Forms.TextBox();
            this.accepttxt = new System.Windows.Forms.TextBox();
            this.acceptbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.deletetxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // friendrequests
            // 
            this.friendrequests.Location = new System.Drawing.Point(0, -1);
            this.friendrequests.Multiline = true;
            this.friendrequests.Name = "friendrequests";
            this.friendrequests.Size = new System.Drawing.Size(120, 223);
            this.friendrequests.TabIndex = 0;
            // 
            // friendstxt
            // 
            this.friendstxt.Location = new System.Drawing.Point(268, 0);
            this.friendstxt.Multiline = true;
            this.friendstxt.Name = "friendstxt";
            this.friendstxt.Size = new System.Drawing.Size(120, 223);
            this.friendstxt.TabIndex = 1;
            // 
            // accepttxt
            // 
            this.accepttxt.Location = new System.Drawing.Point(126, 0);
            this.accepttxt.Name = "accepttxt";
            this.accepttxt.Size = new System.Drawing.Size(136, 20);
            this.accepttxt.TabIndex = 2;
            // 
            // acceptbtn
            // 
            this.acceptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.acceptbtn.Location = new System.Drawing.Point(126, 26);
            this.acceptbtn.Name = "acceptbtn";
            this.acceptbtn.Size = new System.Drawing.Size(136, 45);
            this.acceptbtn.TabIndex = 3;
            this.acceptbtn.Text = "Accept";
            this.acceptbtn.UseVisualStyleBackColor = true;
            this.acceptbtn.Click += new System.EventHandler(this.acceptbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deletebtn.Location = new System.Drawing.Point(126, 177);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(136, 45);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // deletetxt
            // 
            this.deletetxt.Location = new System.Drawing.Point(126, 151);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(136, 20);
            this.deletetxt.TabIndex = 4;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addbtn.Location = new System.Drawing.Point(126, 101);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(136, 45);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(126, 75);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(136, 20);
            this.addtxt.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.friendstxt);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.friendrequests);
            this.panel1.Controls.Add(this.addtxt);
            this.panel1.Controls.Add(this.accepttxt);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.acceptbtn);
            this.panel1.Controls.Add(this.deletetxt);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 223);
            this.panel1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 223);
            this.Controls.Add(this.panel1);
            this.Name = "Friends";
            this.Text = "Friends";
            this.Load += new System.EventHandler(this.Friends_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox friendrequests;
        private System.Windows.Forms.TextBox friendstxt;
        private System.Windows.Forms.TextBox accepttxt;
        private System.Windows.Forms.Button acceptbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox deletetxt;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}