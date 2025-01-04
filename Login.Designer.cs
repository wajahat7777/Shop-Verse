namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CustomerReg = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MailTxt = new System.Windows.Forms.TextBox();
            this.SignUpAsSeller = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerReg
            // 
            this.CustomerReg.AutoSize = true;
            this.CustomerReg.BackColor = System.Drawing.Color.GhostWhite;
            this.CustomerReg.Location = new System.Drawing.Point(18, 659);
            this.CustomerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerReg.Name = "CustomerReg";
            this.CustomerReg.Size = new System.Drawing.Size(160, 20);
            this.CustomerReg.TabIndex = 45;
            this.CustomerReg.TabStop = true;
            this.CustomerReg.Text = "Sign Up as Customer";
            this.CustomerReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomerReg_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(261, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 42;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password:";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(116, 292);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(444, 26);
            this.PassTxt.TabIndex = 40;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "Email:";
            // 
            // MailTxt
            // 
            this.MailTxt.Location = new System.Drawing.Point(116, 209);
            this.MailTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MailTxt.Name = "MailTxt";
            this.MailTxt.Size = new System.Drawing.Size(444, 26);
            this.MailTxt.TabIndex = 38;
            this.MailTxt.TextChanged += new System.EventHandler(this.MailTxt_TextChanged);
            // 
            // SignUpAsSeller
            // 
            this.SignUpAsSeller.AutoSize = true;
            this.SignUpAsSeller.BackColor = System.Drawing.Color.GhostWhite;
            this.SignUpAsSeller.Location = new System.Drawing.Point(526, 659);
            this.SignUpAsSeller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpAsSeller.Name = "SignUpAsSeller";
            this.SignUpAsSeller.Size = new System.Drawing.Size(131, 20);
            this.SignUpAsSeller.TabIndex = 47;
            this.SignUpAsSeller.TabStop = true;
            this.SignUpAsSeller.Text = "Sign Up as Seller";
            this.SignUpAsSeller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GhostWhite;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 37);
            this.label8.TabIndex = 48;
            this.label8.Text = "Sign in";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.checkBox1.Location = new System.Drawing.Point(294, 429);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Seller";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(19, 20);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 35);
            this.BackButton.TabIndex = 50;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 692);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SignUpAsSeller);
            this.Controls.Add(this.CustomerReg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel CustomerReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MailTxt;
        private System.Windows.Forms.LinkLabel SignUpAsSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BackButton;
    }
}