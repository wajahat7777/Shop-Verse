namespace Project
{
    partial class LogOrderTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOrderTracking));
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerInfoTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(18, 252);
            this.OrderGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 62;
            this.OrderGridView.Size = new System.Drawing.Size(885, 231);
            this.OrderGridView.TabIndex = 3;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(356, 492);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(298, 26);
            this.StartDatePicker.TabIndex = 4;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 497);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Date:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDatePicker.Location = new System.Drawing.Point(356, 554);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(298, 26);
            this.EndDatePicker.TabIndex = 6;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.StatusComboBox.Location = new System.Drawing.Point(356, 617);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(298, 28);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 618);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Status: ";
            // 
            // CustomerInfoTxtBox
            // 
            this.CustomerInfoTxtBox.Location = new System.Drawing.Point(93, 54);
            this.CustomerInfoTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerInfoTxtBox.Multiline = true;
            this.CustomerInfoTxtBox.Name = "CustomerInfoTxtBox";
            this.CustomerInfoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerInfoTxtBox.Size = new System.Drawing.Size(373, 138);
            this.CustomerInfoTxtBox.TabIndex = 12;
            this.CustomerInfoTxtBox.TextChanged += new System.EventHandler(this.CustomerInfoTxtBox_TextChanged);
            // 
            // LogOrderTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 771);
            this.Controls.Add(this.CustomerInfoTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.OrderGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogOrderTracking";
            this.Text = "Order Tracking";
            this.Load += new System.EventHandler(this.OrderTracking_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerInfoTxtBox;
    }
}