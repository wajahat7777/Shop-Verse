namespace Project
{
    partial class CustReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustReview));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RatingNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Product:";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(141, 232);
            this.ProductComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(180, 28);
            this.ProductComboBox.TabIndex = 1;
            this.ProductComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rating: ";
            // 
            // RatingNumeric
            // 
            this.RatingNumeric.Location = new System.Drawing.Point(141, 292);
            this.RatingNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RatingNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RatingNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RatingNumeric.Name = "RatingNumeric";
            this.RatingNumeric.Size = new System.Drawing.Size(180, 26);
            this.RatingNumeric.TabIndex = 3;
            this.RatingNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RatingNumeric.ValueChanged += new System.EventHandler(this.RatingNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Review";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Location = new System.Drawing.Point(141, 362);
            this.ReviewTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReviewTextBox.Multiline = true;
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(178, 29);
            this.ReviewTextBox.TabIndex = 5;
            this.ReviewTextBox.TextChanged += new System.EventHandler(this.ReviewTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(169, 421);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 35);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(18, 19);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 35);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CustReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 692);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RatingNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductComboBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustReview";
            this.Text = "Review Form";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RatingNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReviewTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}