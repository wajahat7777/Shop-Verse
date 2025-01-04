namespace Project
{
    partial class CustProductSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustProductSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryTxt = new System.Windows.Forms.Label();
            this.MaxTxt = new System.Windows.Forms.Label();
            this.MinTxt = new System.Windows.Forms.Label();
            this.MinPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.SearchButt = new System.Windows.Forms.Button();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ViewCartLL = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Name:";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(320, 85);
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(148, 26);
            this.SearchTxt.TabIndex = 1;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(896, 91);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(180, 28);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.AutoSize = true;
            this.CategoryTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTxt.Location = new System.Drawing.Point(684, 92);
            this.CategoryTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(176, 23);
            this.CategoryTxt.TabIndex = 3;
            this.CategoryTxt.Text = "Filter By Category:";
            // 
            // MaxTxt
            // 
            this.MaxTxt.AutoSize = true;
            this.MaxTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTxt.Location = new System.Drawing.Point(684, 194);
            this.MaxTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxTxt.Name = "MaxTxt";
            this.MaxTxt.Size = new System.Drawing.Size(104, 23);
            this.MaxTxt.TabIndex = 4;
            this.MaxTxt.Text = "Max Price:";
            // 
            // MinTxt
            // 
            this.MinTxt.AutoSize = true;
            this.MinTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTxt.Location = new System.Drawing.Point(127, 194);
            this.MinTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinTxt.Name = "MinTxt";
            this.MinTxt.Size = new System.Drawing.Size(98, 23);
            this.MinTxt.TabIndex = 5;
            this.MinTxt.Text = "Min Price:";
            // 
            // MinPriceNumeric
            // 
            this.MinPriceNumeric.Location = new System.Drawing.Point(320, 194);
            this.MinPriceNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinPriceNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MinPriceNumeric.Name = "MinPriceNumeric";
            this.MinPriceNumeric.Size = new System.Drawing.Size(180, 26);
            this.MinPriceNumeric.TabIndex = 6;
            this.MinPriceNumeric.ValueChanged += new System.EventHandler(this.MinPriceNumeric_ValueChanged);
            // 
            // MaxPriceNumeric
            // 
            this.MaxPriceNumeric.Location = new System.Drawing.Point(896, 194);
            this.MaxPriceNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxPriceNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MaxPriceNumeric.Name = "MaxPriceNumeric";
            this.MaxPriceNumeric.Size = new System.Drawing.Size(180, 26);
            this.MaxPriceNumeric.TabIndex = 7;
            this.MaxPriceNumeric.ValueChanged += new System.EventHandler(this.MaxPriceNumeric_ValueChanged);
            // 
            // SearchButt
            // 
            this.SearchButt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButt.Location = new System.Drawing.Point(507, 262);
            this.SearchButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.Size = new System.Drawing.Size(207, 55);
            this.SearchButt.TabIndex = 8;
            this.SearchButt.Text = "Search";
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.ColumnHeadersHeight = 29;
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProductsGridView.Location = new System.Drawing.Point(0, 487);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.Size = new System.Drawing.Size(1197, 231);
            this.ProductsGridView.TabIndex = 9;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // ViewCartLL
            // 
            this.ViewCartLL.AutoSize = true;
            this.ViewCartLL.Location = new System.Drawing.Point(1097, 446);
            this.ViewCartLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewCartLL.Name = "ViewCartLL";
            this.ViewCartLL.Size = new System.Drawing.Size(77, 20);
            this.ViewCartLL.TabIndex = 10;
            this.ViewCartLL.TabStop = true;
            this.ViewCartLL.Text = "View Cart";
            this.ViewCartLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewCartLL_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 718);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewCartLL);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.MaxPriceNumeric);
            this.Controls.Add(this.MinPriceNumeric);
            this.Controls.Add(this.MinTxt);
            this.Controls.Add(this.MaxTxt);
            this.Controls.Add(this.CategoryTxt);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustProductSearch";
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.ProductSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryTxt;
        private System.Windows.Forms.Label MaxTxt;
        private System.Windows.Forms.Label MinTxt;
        private System.Windows.Forms.NumericUpDown MinPriceNumeric;
        private System.Windows.Forms.NumericUpDown MaxPriceNumeric;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.LinkLabel ViewCartLL;
        private System.Windows.Forms.Button button1;
    }
}