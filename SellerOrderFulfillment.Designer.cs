namespace Project
{
    partial class SellerOrderFulfillment
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
            this.projectDataSet = new Project.ProjectDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Project.ProjectDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new Project.ProjectDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Project.ProjectDataSetTableAdapters.CustomerTableAdapter();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemTableAdapter = new Project.ProjectDataSetTableAdapters.OrderItemTableAdapter();
            this.paymentTableAdapter = new Project.ProjectDataSetTableAdapters.PaymentTableAdapter();
            this.UpSButt = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.BackButt = new System.Windows.Forms.Button();
            this.fKOrderItemOrder4F12BBB9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPaymentOrderID52E34C9DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderItemOrder4F12BBB9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPaymentOrderID52E34C9DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.projectDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.ElectronicsTableAdapter = null;
            this.tableAdapterManager.FashionTableAdapter = null;
            this.tableAdapterManager.HomeAppliancesTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.projectDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // orderItemTableAdapter
            // 
            this.orderItemTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // UpSButt
            // 
            this.UpSButt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpSButt.Location = new System.Drawing.Point(505, 515);
            this.UpSButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpSButt.Name = "UpSButt";
            this.UpSButt.Size = new System.Drawing.Size(182, 58);
            this.UpSButt.TabIndex = 1;
            this.UpSButt.Text = "Update Status";
            this.UpSButt.UseVisualStyleBackColor = true;
            this.UpSButt.Click += new System.EventHandler(this.UpSButt_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(504, 452);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(180, 28);
            this.StatusComboBox.TabIndex = 2;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(18, 18);
            this.BackButt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(112, 35);
            this.BackButt.TabIndex = 3;
            this.BackButt.Text = "< Back";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // fKOrderItemOrder4F12BBB9BindingSource
            // 
            this.fKOrderItemOrder4F12BBB9BindingSource.DataMember = "FK__OrderItem__Order__4F12BBB9";
            this.fKOrderItemOrder4F12BBB9BindingSource.DataSource = this.ordersBindingSource;
            // 
            // fKPaymentOrderID52E34C9DBindingSource
            // 
            this.fKPaymentOrderID52E34C9DBindingSource.DataMember = "FK__Payment__OrderID__52E34C9D";
            this.fKPaymentOrderID52E34C9DBindingSource.DataSource = this.ordersBindingSource;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "FK__Orders__Customer__44952D46";
            this.ordersBindingSource1.DataSource = this.customerBindingSource;
            // 
            // SellerOrderFulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 692);
            this.Controls.Add(this.BackButt);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.UpSButt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellerOrderFulfillment";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderItemOrder4F12BBB9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPaymentOrderID52E34C9DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ProjectDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ProjectDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKOrderItemOrder4F12BBB9BindingSource;
        private ProjectDataSetTableAdapters.OrderItemTableAdapter orderItemTableAdapter;
        private System.Windows.Forms.BindingSource fKPaymentOrderID52E34C9DBindingSource;
        private ProjectDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Button UpSButt;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button BackButt;
    }
}