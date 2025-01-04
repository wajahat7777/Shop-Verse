namespace Project
{
    partial class LogInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInterface));
            this.Logout = new System.Windows.Forms.Button();
            this.ShipmentTrackButton = new System.Windows.Forms.Button();
            this.TrackOrdersButton = new System.Windows.Forms.Button();
            this.NotifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(18, 18);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(112, 35);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ShipmentTrackButton
            // 
            this.ShipmentTrackButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipmentTrackButton.Location = new System.Drawing.Point(110, 426);
            this.ShipmentTrackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipmentTrackButton.Name = "ShipmentTrackButton";
            this.ShipmentTrackButton.Size = new System.Drawing.Size(417, 69);
            this.ShipmentTrackButton.TabIndex = 9;
            this.ShipmentTrackButton.Text = "Track Shipment";
            this.ShipmentTrackButton.UseVisualStyleBackColor = true;
            this.ShipmentTrackButton.Click += new System.EventHandler(this.ShipmentTrackButton_Click);
            // 
            // TrackOrdersButton
            // 
            this.TrackOrdersButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackOrdersButton.Location = new System.Drawing.Point(110, 309);
            this.TrackOrdersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TrackOrdersButton.Name = "TrackOrdersButton";
            this.TrackOrdersButton.Size = new System.Drawing.Size(417, 69);
            this.TrackOrdersButton.TabIndex = 8;
            this.TrackOrdersButton.Text = "Track Orders";
            this.TrackOrdersButton.UseVisualStyleBackColor = true;
            this.TrackOrdersButton.Click += new System.EventHandler(this.TrackOrdersButton_Click);
            // 
            // NotifyButton
            // 
            this.NotifyButton.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyButton.Location = new System.Drawing.Point(110, 194);
            this.NotifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotifyButton.Name = "NotifyButton";
            this.NotifyButton.Size = new System.Drawing.Size(417, 69);
            this.NotifyButton.TabIndex = 7;
            this.NotifyButton.Text = "Notification Panel";
            this.NotifyButton.UseVisualStyleBackColor = true;
            this.NotifyButton.Click += new System.EventHandler(this.NotifyButton_Click);
            // 
            // LogInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 692);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ShipmentTrackButton);
            this.Controls.Add(this.TrackOrdersButton);
            this.Controls.Add(this.NotifyButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogInterface";
            this.Text = "Logistics Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ShipmentTrackButton;
        private System.Windows.Forms.Button TrackOrdersButton;
        private System.Windows.Forms.Button NotifyButton;
    }
}