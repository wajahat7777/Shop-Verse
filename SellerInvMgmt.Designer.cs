namespace Project
{
    partial class SellerInvMgmt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerInvMgmt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.projectDataSet = new Project.ProjectDataSet();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.StTxt = new System.Windows.Forms.TextBox();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project.ProjectDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new Project.ProjectDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Project.ProjectDataSetTableAdapters.ProductsTableAdapter();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateButt = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.SearchButt = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // NameTxt
            // 
            resources.ApplyResources(this.NameTxt, "NameTxt");
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // DescTxt
            // 
            resources.ApplyResources(this.DescTxt, "DescTxt");
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.TextChanged += new System.EventHandler(this.DescTxt_TextChanged);
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriceTxt
            // 
            resources.ApplyResources(this.PriceTxt, "PriceTxt");
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            // 
            // StTxt
            // 
            resources.ApplyResources(this.StTxt, "StTxt");
            this.StTxt.Name = "StTxt";
            this.StTxt.TextChanged += new System.EventHandler(this.StTxt_TextChanged);
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ElectronicsTableAdapter = null;
            this.tableAdapterManager.FashionTableAdapter = null;
            this.tableAdapterManager.HomeAppliancesTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ReportTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.SellerProductTableAdapter = null;
            this.tableAdapterManager.SellerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project.ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WishlistItemTableAdapter = null;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.projectDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryComboBox
            // 
            resources.ApplyResources(this.CategoryComboBox, "CategoryComboBox");
            this.CategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "CategoryID", true));
            this.CategoryComboBox.DataSource = this.categoryBindingSource;
            this.CategoryComboBox.DisplayMember = "Name";
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.ValueMember = "CategoryID";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSetBindingSource1
            // 
            this.projectDataSetBindingSource1.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource1.Position = 0;
            // 
            // UpdateButt
            // 
            resources.ApplyResources(this.UpdateButt, "UpdateButt");
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.UseVisualStyleBackColor = true;
            this.UpdateButt.Click += new System.EventHandler(this.UpdateButt_Click);
            // 
            // DeleteButt
            // 
            resources.ApplyResources(this.DeleteButt, "DeleteButt");
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // SearchButt
            // 
            resources.ApplyResources(this.SearchButt, "SearchButt");
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // SearchTxt
            // 
            resources.ApplyResources(this.SearchTxt, "SearchTxt");
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SellerInvMgmt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.UpdateButt);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StTxt);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.DescTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellerInvMgmt";
            this.Load += new System.EventHandler(this.InvMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.TextBox StTxt;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private ProjectDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProjectDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource1;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button SearchButt;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}