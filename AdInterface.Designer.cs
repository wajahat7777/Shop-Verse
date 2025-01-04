namespace Project
{
    partial class AdInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdInterface));
            this.AdOrderMgmtButton = new System.Windows.Forms.Button();
            this.PrCatMgmt = new System.Windows.Forms.Button();
            this.ReviewModButton = new System.Windows.Forms.Button();
            this.AdReportButton = new System.Windows.Forms.Button();
            this.AdSellCust = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdOrderMgmtButton
            // 
            this.AdOrderMgmtButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.AdOrderMgmtButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AdOrderMgmtButton.FlatAppearance.BorderSize = 5;
            this.AdOrderMgmtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.AdOrderMgmtButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AdOrderMgmtButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdOrderMgmtButton.Location = new System.Drawing.Point(138, 112);
            this.AdOrderMgmtButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdOrderMgmtButton.Name = "AdOrderMgmtButton";
            this.AdOrderMgmtButton.Padding = new System.Windows.Forms.Padding(2);
            this.AdOrderMgmtButton.Size = new System.Drawing.Size(417, 69);
            this.AdOrderMgmtButton.TabIndex = 0;
            this.AdOrderMgmtButton.Text = "Order Management";
            this.AdOrderMgmtButton.UseVisualStyleBackColor = true;
            this.AdOrderMgmtButton.Click += new System.EventHandler(this.AdOrderMgmtButton_Click);
            // 
            // PrCatMgmt
            // 
            this.PrCatMgmt.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.PrCatMgmt.Location = new System.Drawing.Point(138, 228);
            this.PrCatMgmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrCatMgmt.Name = "PrCatMgmt";
            this.PrCatMgmt.Size = new System.Drawing.Size(417, 69);
            this.PrCatMgmt.TabIndex = 1;
            this.PrCatMgmt.Text = "Product and Category Management";
            this.PrCatMgmt.UseVisualStyleBackColor = true;
            this.PrCatMgmt.Click += new System.EventHandler(this.PrCatMgmt_Click);
            // 
            // ReviewModButton
            // 
            this.ReviewModButton.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.ReviewModButton.Location = new System.Drawing.Point(138, 345);
            this.ReviewModButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReviewModButton.Name = "ReviewModButton";
            this.ReviewModButton.Size = new System.Drawing.Size(417, 69);
            this.ReviewModButton.TabIndex = 2;
            this.ReviewModButton.Text = "Review Moderation";
            this.ReviewModButton.UseVisualStyleBackColor = true;
            this.ReviewModButton.Click += new System.EventHandler(this.ReviewModButton_Click);
            // 
            // AdReportButton
            // 
            this.AdReportButton.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.AdReportButton.Location = new System.Drawing.Point(138, 591);
            this.AdReportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdReportButton.Name = "AdReportButton";
            this.AdReportButton.Size = new System.Drawing.Size(417, 69);
            this.AdReportButton.TabIndex = 4;
            this.AdReportButton.Text = "Reports";
            this.AdReportButton.UseVisualStyleBackColor = true;
            this.AdReportButton.Click += new System.EventHandler(this.AdReportButton_Click);
            // 
            // AdSellCust
            // 
            this.AdSellCust.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.AdSellCust.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AdSellCust.Location = new System.Drawing.Point(138, 471);
            this.AdSellCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdSellCust.Name = "AdSellCust";
            this.AdSellCust.Size = new System.Drawing.Size(417, 69);
            this.AdSellCust.TabIndex = 5;
            this.AdSellCust.Text = "Seller and Customer Management";
            this.AdSellCust.UseVisualStyleBackColor = true;
            this.AdSellCust.Click += new System.EventHandler(this.AdSellCust_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(19, 20);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(112, 35);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 711);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.AdSellCust);
            this.Controls.Add(this.AdReportButton);
            this.Controls.Add(this.ReviewModButton);
            this.Controls.Add(this.PrCatMgmt);
            this.Controls.Add(this.AdOrderMgmtButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdInterface";
            this.Text = "Admin Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdOrderMgmtButton;
        private System.Windows.Forms.Button PrCatMgmt;
        private System.Windows.Forms.Button ReviewModButton;
        private System.Windows.Forms.Button AdReportButton;
        private System.Windows.Forms.Button AdSellCust;
        private System.Windows.Forms.Button Logout;
    }
}