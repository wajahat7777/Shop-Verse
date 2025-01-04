namespace Project
{
    partial class LogShipmentTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogShipmentTracking));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AssignButton = new System.Windows.Forms.Button();
            this.EstimatedDeliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.AssignedToComboBox = new System.Windows.Forms.ComboBox();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ActualDeliveryPicker = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ShipmentsGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AssignButton);
            this.tabPage1.Controls.Add(this.EstimatedDeliveryPicker);
            this.tabPage1.Controls.Add(this.AssignedToComboBox);
            this.tabPage1.Controls.Add(this.OrdersGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order Assignment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(581, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose Estimated Delivery Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Delivery Partner:";
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(532, 191);
            this.AssignButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(112, 35);
            this.AssignButton.TabIndex = 3;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // EstimatedDeliveryPicker
            // 
            this.EstimatedDeliveryPicker.Location = new System.Drawing.Point(831, 86);
            this.EstimatedDeliveryPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EstimatedDeliveryPicker.Name = "EstimatedDeliveryPicker";
            this.EstimatedDeliveryPicker.Size = new System.Drawing.Size(318, 26);
            this.EstimatedDeliveryPicker.TabIndex = 2;
            // 
            // AssignedToComboBox
            // 
            this.AssignedToComboBox.FormattingEnabled = true;
            this.AssignedToComboBox.Items.AddRange(new object[] {
            "TCS",
            "Leopard\'s Courier",
            "FedEx",
            "M&P",
            "DHL"});
            this.AssignedToComboBox.Location = new System.Drawing.Point(243, 85);
            this.AssignedToComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AssignedToComboBox.Name = "AssignedToComboBox";
            this.AssignedToComboBox.Size = new System.Drawing.Size(180, 28);
            this.AssignedToComboBox.TabIndex = 1;
            this.AssignedToComboBox.SelectedIndexChanged += new System.EventHandler(this.AssignedToComboBox_SelectedIndexChanged);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersGridView.Location = new System.Drawing.Point(4, 289);
            this.OrdersGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 62;
            this.OrdersGridView.Size = new System.Drawing.Size(1184, 365);
            this.OrdersGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.UpdateButton);
            this.tabPage2.Controls.Add(this.ActualDeliveryPicker);
            this.tabPage2.Controls.Add(this.StatusComboBox);
            this.tabPage2.Controls.Add(this.ShipmentsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shipment Tracking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Actual Delivery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(525, 242);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(112, 35);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ActualDeliveryPicker
            // 
            this.ActualDeliveryPicker.Location = new System.Drawing.Point(789, 137);
            this.ActualDeliveryPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActualDeliveryPicker.Name = "ActualDeliveryPicker";
            this.ActualDeliveryPicker.Size = new System.Drawing.Size(318, 26);
            this.ActualDeliveryPicker.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.StatusComboBox.Location = new System.Drawing.Point(201, 135);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(180, 28);
            this.StatusComboBox.TabIndex = 6;
            // 
            // ShipmentsGridView
            // 
            this.ShipmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShipmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShipmentsGridView.Location = new System.Drawing.Point(4, 362);
            this.ShipmentsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShipmentsGridView.Name = "ShipmentsGridView";
            this.ShipmentsGridView.RowHeadersWidth = 62;
            this.ShipmentsGridView.Size = new System.Drawing.Size(1184, 292);
            this.ShipmentsGridView.TabIndex = 0;
            // 
            // LogShipmentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogShipmentTracking";
            this.Text = "ShipmentTracking";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.DateTimePicker EstimatedDeliveryPicker;
        private System.Windows.Forms.ComboBox AssignedToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ShipmentsGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker ActualDeliveryPicker;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}