namespace Project
{
    partial class AdReviewMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdReviewMod));
            this.ReviewGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxReviewStatus = new System.Windows.Forms.ComboBox();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.txtRejectionReason = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReviewGridView
            // 
            this.ReviewGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReviewGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReviewGridView.Location = new System.Drawing.Point(0, 551);
            this.ReviewGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReviewGridView.Name = "ReviewGridView";
            this.ReviewGridView.RowHeadersWidth = 62;
            this.ReviewGridView.Size = new System.Drawing.Size(1556, 331);
            this.ReviewGridView.TabIndex = 0;
            this.ReviewGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewGridView_CellContentClick);
            // 
            // comboBoxReviewStatus
            // 
            this.comboBoxReviewStatus.FormattingEnabled = true;
            this.comboBoxReviewStatus.Location = new System.Drawing.Point(616, 78);
            this.comboBoxReviewStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxReviewStatus.Name = "comboBoxReviewStatus";
            this.comboBoxReviewStatus.Size = new System.Drawing.Size(325, 28);
            this.comboBoxReviewStatus.TabIndex = 1;
            this.comboBoxReviewStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxReviewStatus_SelectedIndexChanged);
            // 
            // ApproveButton
            // 
            this.ApproveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveButton.Location = new System.Drawing.Point(616, 202);
            this.ApproveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(327, 57);
            this.ApproveButton.TabIndex = 2;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click_1);
            // 
            // RejectButton
            // 
            this.RejectButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectButton.Location = new System.Drawing.Point(616, 268);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(327, 57);
            this.RejectButton.TabIndex = 3;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click_1);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(616, 334);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(327, 57);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // txtRejectionReason
            // 
            this.txtRejectionReason.Location = new System.Drawing.Point(1005, 283);
            this.txtRejectionReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRejectionReason.Name = "txtRejectionReason";
            this.txtRejectionReason.Size = new System.Drawing.Size(302, 26);
            this.txtRejectionReason.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(616, 135);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(327, 57);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(616, 400);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(327, 57);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AdReviewMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 882);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.txtRejectionReason);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.comboBoxReviewStatus);
            this.Controls.Add(this.ReviewGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdReviewMod";
            this.Text = "AdReviewMod";
            this.Load += new System.EventHandler(this.AdReviewMod_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReviewGridView;
        private System.Windows.Forms.ComboBox comboBoxReviewStatus;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox txtRejectionReason;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button SaveButton;
    }
}