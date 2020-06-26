namespace SMP.Forms
{
    partial class News
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
            this.posttxt = new System.Windows.Forms.TextBox();
            this.postbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.friendsbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.poststxt = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // posttxt
            // 
            this.posttxt.Location = new System.Drawing.Point(0, 488);
            this.posttxt.Multiline = true;
            this.posttxt.Name = "posttxt";
            this.posttxt.Size = new System.Drawing.Size(756, 110);
            this.posttxt.TabIndex = 1;
            this.posttxt.TextChanged += new System.EventHandler(this.posttxt_TextChanged);
            // 
            // postbtn
            // 
            this.postbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.postbtn.Location = new System.Drawing.Point(762, 544);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(136, 48);
            this.postbtn.TabIndex = 2;
            this.postbtn.Text = "Post";
            this.postbtn.UseVisualStyleBackColor = true;
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // friendsbtn
            // 
            this.friendsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.friendsbtn.Location = new System.Drawing.Point(762, 488);
            this.friendsbtn.Name = "friendsbtn";
            this.friendsbtn.Size = new System.Drawing.Size(136, 50);
            this.friendsbtn.TabIndex = 3;
            this.friendsbtn.Text = "Friends Tab";
            this.friendsbtn.UseVisualStyleBackColor = true;
            this.friendsbtn.Click += new System.EventHandler(this.friendsbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.postbtn);
            this.panel1.Controls.Add(this.friendsbtn);
            this.panel1.Controls.Add(this.posttxt);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 598);
            this.panel1.TabIndex = 4;
            // 
            // poststxt
            // 
            this.poststxt.Location = new System.Drawing.Point(0, 0);
            this.poststxt.Name = "poststxt";
            this.poststxt.Size = new System.Drawing.Size(898, 481);
            this.poststxt.TabIndex = 5;
            this.poststxt.Text = "";
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 597);
            this.Controls.Add(this.poststxt);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "News";
            this.Text = "News";
            this.Load += new System.EventHandler(this.News_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox posttxt;
        private System.Windows.Forms.Button postbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox poststxt;
    }
}