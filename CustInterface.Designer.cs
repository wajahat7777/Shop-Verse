namespace Project
{
    partial class CustInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustInterface));
            this.ProfileMgmt = new System.Windows.Forms.Button();
            this.ReviewOrd = new System.Windows.Forms.Button();
            this.ViewCart = new System.Windows.Forms.Button();
            this.PrSearch = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileMgmt
            // 
            this.ProfileMgmt.CausesValidation = false;
            this.ProfileMgmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMgmt.Location = new System.Drawing.Point(164, 409);
            this.ProfileMgmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileMgmt.Name = "ProfileMgmt";
            this.ProfileMgmt.Size = new System.Drawing.Size(287, 91);
            this.ProfileMgmt.TabIndex = 10;
            this.ProfileMgmt.Text = "Manage Profile";
            this.ProfileMgmt.UseVisualStyleBackColor = true;
            this.ProfileMgmt.Click += new System.EventHandler(this.ProfileMgmt_Click);
            // 
            // ReviewOrd
            // 
            this.ReviewOrd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewOrd.Location = new System.Drawing.Point(164, 308);
            this.ReviewOrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReviewOrd.Name = "ReviewOrd";
            this.ReviewOrd.Size = new System.Drawing.Size(287, 91);
            this.ReviewOrd.TabIndex = 9;
            this.ReviewOrd.Text = "Review Orders";
            this.ReviewOrd.UseVisualStyleBackColor = true;
            this.ReviewOrd.Click += new System.EventHandler(this.ReviewOrd_Click);
            // 
            // ViewCart
            // 
            this.ViewCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCart.Location = new System.Drawing.Point(164, 206);
            this.ViewCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.Size = new System.Drawing.Size(287, 91);
            this.ViewCart.TabIndex = 8;
            this.ViewCart.Text = "View Cart";
            this.ViewCart.UseVisualStyleBackColor = true;
            this.ViewCart.Click += new System.EventHandler(this.ViewCart_Click);
            // 
            // PrSearch
            // 
            this.PrSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrSearch.Location = new System.Drawing.Point(164, 105);
            this.PrSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrSearch.Name = "PrSearch";
            this.PrSearch.Size = new System.Drawing.Size(287, 91);
            this.PrSearch.TabIndex = 7;
            this.PrSearch.Text = "Product Search";
            this.PrSearch.UseVisualStyleBackColor = true;
            this.PrSearch.Click += new System.EventHandler(this.PrSearch_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LogOutButton.Location = new System.Drawing.Point(240, 579);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(116, 45);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CustInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 728);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ProfileMgmt);
            this.Controls.Add(this.ReviewOrd);
            this.Controls.Add(this.ViewCart);
            this.Controls.Add(this.PrSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustInterface";
            this.Text = "Customer Interface";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProfileMgmt;
        private System.Windows.Forms.Button ReviewOrd;
        private System.Windows.Forms.Button ViewCart;
        private System.Windows.Forms.Button PrSearch;
        private System.Windows.Forms.Button LogOutButton;
    }
}