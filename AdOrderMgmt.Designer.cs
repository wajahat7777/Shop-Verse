namespace Project
{
    partial class AdOrderMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdOrderMgmt));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.UpdateStatusButton = new System.Windows.Forms.Button();
            this.ViewOrderButton = new System.Windows.Forms.Button();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.Size = new System.Drawing.Size(489, 717);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(524, 214);
            this.comboBoxOrderStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(166, 28);
            this.comboBoxOrderStatus.TabIndex = 1;
            this.comboBoxOrderStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrderStatus_SelectedIndexChanged);
            // 
            // UpdateStatusButton
            // 
            this.UpdateStatusButton.Location = new System.Drawing.Point(524, 400);
            this.UpdateStatusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateStatusButton.Name = "UpdateStatusButton";
            this.UpdateStatusButton.Size = new System.Drawing.Size(168, 55);
            this.UpdateStatusButton.TabIndex = 2;
            this.UpdateStatusButton.Text = "Update Status";
            this.UpdateStatusButton.UseVisualStyleBackColor = true;
            this.UpdateStatusButton.Click += new System.EventHandler(this.UpdateStatusButton_Click);
            // 
            // ViewOrderButton
            // 
            this.ViewOrderButton.Location = new System.Drawing.Point(524, 483);
            this.ViewOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewOrderButton.Name = "ViewOrderButton";
            this.ViewOrderButton.Size = new System.Drawing.Size(168, 58);
            this.ViewOrderButton.TabIndex = 3;
            this.ViewOrderButton.Text = "View Order";
            this.ViewOrderButton.UseVisualStyleBackColor = true;
            this.ViewOrderButton.Click += new System.EventHandler(this.ViewOrderButton_Click);
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AllowUserToAddRows = false;
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(723, 0);
            this.dataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 62;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(519, 717);
            this.dataGridViewOrderDetails.TabIndex = 4;
            this.dataGridViewOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 683);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(942, 683);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order Details";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(524, 318);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(168, 55);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // AdOrderMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1242, 717);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.ViewOrderButton);
            this.Controls.Add(this.UpdateStatusButton);
            this.Controls.Add(this.comboBoxOrderStatus);
            this.Controls.Add(this.dataGridViewOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdOrderMgmt";
            this.Text = "AdOrderMgmt";
            this.Load += new System.EventHandler(this.AdOrderMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.Button UpdateStatusButton;
        private System.Windows.Forms.Button ViewOrderButton;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FilterButton;
    }
}