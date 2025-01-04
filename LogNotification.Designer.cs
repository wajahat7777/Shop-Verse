namespace Project
{
    partial class LogNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogNotification));
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.DeliveryGridView = new System.Windows.Forms.DataGridView();
            this.NotifyButton = new System.Windows.Forms.Button();
            this.DeliveryStatusComboBox = new System.Windows.Forms.ComboBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.Location = new System.Drawing.Point(471, 71);
            this.NotificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(292, 41);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "Notify Customers";
            // 
            // DeliveryGridView
            // 
            this.DeliveryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeliveryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DeliveryGridView.Location = new System.Drawing.Point(0, 369);
            this.DeliveryGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliveryGridView.Name = "DeliveryGridView";
            this.DeliveryGridView.RowHeadersWidth = 62;
            this.DeliveryGridView.Size = new System.Drawing.Size(1200, 323);
            this.DeliveryGridView.TabIndex = 1;
            // 
            // NotifyButton
            // 
            this.NotifyButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyButton.Location = new System.Drawing.Point(772, 217);
            this.NotifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotifyButton.Name = "NotifyButton";
            this.NotifyButton.Size = new System.Drawing.Size(112, 35);
            this.NotifyButton.TabIndex = 2;
            this.NotifyButton.Text = "Notify";
            this.NotifyButton.UseVisualStyleBackColor = true;
            this.NotifyButton.Click += new System.EventHandler(this.NotifyButton_Click);
            // 
            // DeliveryStatusComboBox
            // 
            this.DeliveryStatusComboBox.FormattingEnabled = true;
            this.DeliveryStatusComboBox.Location = new System.Drawing.Point(332, 220);
            this.DeliveryStatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeliveryStatusComboBox.Name = "DeliveryStatusComboBox";
            this.DeliveryStatusComboBox.Size = new System.Drawing.Size(392, 28);
            this.DeliveryStatusComboBox.TabIndex = 3;
            this.DeliveryStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryStatusComboBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(18, 18);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 35);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DeliveryStatusComboBox);
            this.Controls.Add(this.NotifyButton);
            this.Controls.Add(this.DeliveryGridView);
            this.Controls.Add(this.NotificationLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogNotification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.DataGridView DeliveryGridView;
        private System.Windows.Forms.Button NotifyButton;
        private System.Windows.Forms.ComboBox DeliveryStatusComboBox;
        private System.Windows.Forms.Button BackButton;
    }
}