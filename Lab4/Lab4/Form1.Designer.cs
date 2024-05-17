using System;
using System.Windows.Forms;

namespace Lab4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_luu_product = new System.Windows.Forms.Button();
            this.btn_capnhat_product = new System.Windows.Forms.Button();
            this.btn_xoa_product = new System.Windows.Forms.Button();
            this.btn_them_product = new System.Windows.Forms.Button();
            this.txt_storagelocation = new System.Windows.Forms.TextBox();
            this.txt_stockquantity = new System.Windows.Forms.TextBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLQuery_ABCDataSet = new Lab4.SQLQuery_ABCDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_luu_order = new System.Windows.Forms.Button();
            this.dtp_orderdate = new System.Windows.Forms.DateTimePicker();
            this.btn_capnhat_order = new System.Windows.Forms.Button();
            this.btn_xoa_order = new System.Windows.Forms.Button();
            this.btn_them_order = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.txt_employee_order = new System.Windows.Forms.TextBox();
            this.txt_productid_order = new System.Windows.Forms.TextBox();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_luu_employee = new System.Windows.Forms.Button();
            this.btn_capnhat_employee = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.btn_xoa_employee = new System.Windows.Forms.Button();
            this.btn_them_employee = new System.Windows.Forms.Button();
            this.txt_employeename = new System.Windows.Forms.TextBox();
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sQLQuery_ABCDataSet3 = new Lab4.SQLQuery_ABCDataSet3();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLQuery_ABCDataSet2 = new Lab4.SQLQuery_ABCDataSet2();
            this.productTableAdapter = new Lab4.SQLQuery_ABCDataSetTableAdapters.ProductTableAdapter();
            this.sQLQuery_ABCDataSet1 = new Lab4.SQLQuery_ABCDataSet1();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new Lab4.SQLQuery_ABCDataSet1TableAdapters.OrderTableAdapter();
            this.employeeTableAdapter = new Lab4.SQLQuery_ABCDataSet2TableAdapters.EmployeeTableAdapter();
            this.employeeTableAdapter1 = new Lab4.SQLQuery_ABCDataSet3TableAdapters.EmployeeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_luu_product);
            this.groupBox1.Controls.Add(this.btn_capnhat_product);
            this.groupBox1.Controls.Add(this.btn_xoa_product);
            this.groupBox1.Controls.Add(this.btn_them_product);
            this.groupBox1.Controls.Add(this.txt_storagelocation);
            this.groupBox1.Controls.Add(this.txt_stockquantity);
            this.groupBox1.Controls.Add(this.txt_productname);
            this.groupBox1.Controls.Add(this.txt_productid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(308, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // btn_luu_product
            // 
            this.btn_luu_product.Location = new System.Drawing.Point(242, 155);
            this.btn_luu_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_product.Name = "btn_luu_product";
            this.btn_luu_product.Size = new System.Drawing.Size(56, 19);
            this.btn_luu_product.TabIndex = 23;
            this.btn_luu_product.Text = "Lưu";
            this.btn_luu_product.UseVisualStyleBackColor = true;
            this.btn_luu_product.Click += new System.EventHandler(this.btn_luu_product_Click);
            // 
            // btn_capnhat_product
            // 
            this.btn_capnhat_product.Location = new System.Drawing.Point(155, 155);
            this.btn_capnhat_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_capnhat_product.Name = "btn_capnhat_product";
            this.btn_capnhat_product.Size = new System.Drawing.Size(71, 19);
            this.btn_capnhat_product.TabIndex = 22;
            this.btn_capnhat_product.Text = "Cập nhật";
            this.btn_capnhat_product.UseVisualStyleBackColor = true;
            this.btn_capnhat_product.Click += new System.EventHandler(this.btn_capnhat_product_Click);
            // 
            // btn_xoa_product
            // 
            this.btn_xoa_product.Location = new System.Drawing.Point(82, 155);
            this.btn_xoa_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_product.Name = "btn_xoa_product";
            this.btn_xoa_product.Size = new System.Drawing.Size(56, 19);
            this.btn_xoa_product.TabIndex = 21;
            this.btn_xoa_product.Text = "Xóa";
            this.btn_xoa_product.UseVisualStyleBackColor = true;
            this.btn_xoa_product.Click += new System.EventHandler(this.btn_xoa_product_Click);
            // 
            // btn_them_product
            // 
            this.btn_them_product.Location = new System.Drawing.Point(10, 155);
            this.btn_them_product.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_product.Name = "btn_them_product";
            this.btn_them_product.Size = new System.Drawing.Size(56, 19);
            this.btn_them_product.TabIndex = 20;
            this.btn_them_product.Text = "Thêm";
            this.btn_them_product.UseVisualStyleBackColor = true;
            // 
            // txt_storagelocation
            // 
            this.txt_storagelocation.Location = new System.Drawing.Point(128, 103);
            this.txt_storagelocation.Margin = new System.Windows.Forms.Padding(2);
            this.txt_storagelocation.Name = "txt_storagelocation";
            this.txt_storagelocation.Size = new System.Drawing.Size(154, 20);
            this.txt_storagelocation.TabIndex = 19;
            // 
            // txt_stockquantity
            // 
            this.txt_stockquantity.Location = new System.Drawing.Point(128, 79);
            this.txt_stockquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stockquantity.Name = "txt_stockquantity";
            this.txt_stockquantity.Size = new System.Drawing.Size(154, 20);
            this.txt_stockquantity.TabIndex = 18;
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(128, 54);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(154, 20);
            this.txt_productname.TabIndex = 17;
            // 
            // txt_productid
            // 
            this.txt_productid.Location = new System.Drawing.Point(128, 30);
            this.txt_productid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(154, 20);
            this.txt_productid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Storage_Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stock_Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product_Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product_ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Location = new System.Drawing.Point(336, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(566, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết ";
            // 
            // dgv1
            // 
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.stockQuantityDataGridViewTextBoxColumn,
            this.storageLocationDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.productBindingSource;
            this.dgv1.Location = new System.Drawing.Point(1, 18);
            this.dgv1.Margin = new System.Windows.Forms.Padding(2);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(561, 156);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            this.stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            this.stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            this.stockQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // storageLocationDataGridViewTextBoxColumn
            // 
            this.storageLocationDataGridViewTextBoxColumn.DataPropertyName = "StorageLocation";
            this.storageLocationDataGridViewTextBoxColumn.HeaderText = "StorageLocation";
            this.storageLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageLocationDataGridViewTextBoxColumn.Name = "storageLocationDataGridViewTextBoxColumn";
            this.storageLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sQLQuery_ABCDataSet;
            // 
            // sQLQuery_ABCDataSet
            // 
            this.sQLQuery_ABCDataSet.DataSetName = "SQLQuery_ABCDataSet";
            this.sQLQuery_ABCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_luu_order);
            this.groupBox3.Controls.Add(this.dtp_orderdate);
            this.groupBox3.Controls.Add(this.btn_capnhat_order);
            this.groupBox3.Controls.Add(this.btn_xoa_order);
            this.groupBox3.Controls.Add(this.btn_them_order);
            this.groupBox3.Controls.Add(this.txt_quantity);
            this.groupBox3.Controls.Add(this.txt_customername);
            this.groupBox3.Controls.Add(this.txt_employee_order);
            this.groupBox3.Controls.Add(this.txt_productid_order);
            this.groupBox3.Controls.Add(this.txt_orderid);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(10, 199);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(308, 184);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // btn_luu_order
            // 
            this.btn_luu_order.Location = new System.Drawing.Point(242, 161);
            this.btn_luu_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_order.Name = "btn_luu_order";
            this.btn_luu_order.Size = new System.Drawing.Size(56, 19);
            this.btn_luu_order.TabIndex = 24;
            this.btn_luu_order.Text = "Lưu";
            this.btn_luu_order.UseVisualStyleBackColor = true;
            this.btn_luu_order.Click += new System.EventHandler(this.btn_luu_order_Click);
            // 
            // dtp_orderdate
            // 
            this.dtp_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate.Location = new System.Drawing.Point(134, 140);
            this.dtp_orderdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_orderdate.Name = "dtp_orderdate";
            this.dtp_orderdate.Size = new System.Drawing.Size(157, 20);
            this.dtp_orderdate.TabIndex = 35;
            // 
            // btn_capnhat_order
            // 
            this.btn_capnhat_order.Location = new System.Drawing.Point(155, 162);
            this.btn_capnhat_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_capnhat_order.Name = "btn_capnhat_order";
            this.btn_capnhat_order.Size = new System.Drawing.Size(71, 19);
            this.btn_capnhat_order.TabIndex = 28;
            this.btn_capnhat_order.Text = "Cập nhật";
            this.btn_capnhat_order.UseVisualStyleBackColor = true;
            this.btn_capnhat_order.Click += new System.EventHandler(this.btn_capnhat_order_Click);
            // 
            // btn_xoa_order
            // 
            this.btn_xoa_order.Location = new System.Drawing.Point(82, 162);
            this.btn_xoa_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_order.Name = "btn_xoa_order";
            this.btn_xoa_order.Size = new System.Drawing.Size(56, 19);
            this.btn_xoa_order.TabIndex = 26;
            this.btn_xoa_order.Text = "Xóa";
            this.btn_xoa_order.UseVisualStyleBackColor = true;
            this.btn_xoa_order.Click += new System.EventHandler(this.btn_xoa_order_Click);
            // 
            // btn_them_order
            // 
            this.btn_them_order.Location = new System.Drawing.Point(10, 162);
            this.btn_them_order.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_order.Name = "btn_them_order";
            this.btn_them_order.Size = new System.Drawing.Size(56, 19);
            this.btn_them_order.TabIndex = 24;
            this.btn_them_order.Text = "Thêm";
            this.btn_them_order.UseVisualStyleBackColor = true;
            this.btn_them_order.Click += new System.EventHandler(this.btn_them_order_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(134, 117);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(157, 20);
            this.txt_quantity.TabIndex = 34;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(134, 94);
            this.txt_customername.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(157, 20);
            this.txt_customername.TabIndex = 33;
            // 
            // txt_employee_order
            // 
            this.txt_employee_order.Location = new System.Drawing.Point(134, 72);
            this.txt_employee_order.Margin = new System.Windows.Forms.Padding(2);
            this.txt_employee_order.Name = "txt_employee_order";
            this.txt_employee_order.Size = new System.Drawing.Size(157, 20);
            this.txt_employee_order.TabIndex = 32;
            // 
            // txt_productid_order
            // 
            this.txt_productid_order.Location = new System.Drawing.Point(134, 49);
            this.txt_productid_order.Margin = new System.Windows.Forms.Padding(2);
            this.txt_productid_order.Name = "txt_productid_order";
            this.txt_productid_order.Size = new System.Drawing.Size(157, 20);
            this.txt_productid_order.TabIndex = 31;
            // 
            // txt_orderid
            // 
            this.txt_orderid.Location = new System.Drawing.Point(134, 26);
            this.txt_orderid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(157, 20);
            this.txt_orderid.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Customer_Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order_ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Employee_ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product_ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv2);
            this.groupBox4.Location = new System.Drawing.Point(336, 199);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(566, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(0, 18);
            this.dgv2.Margin = new System.Windows.Forms.Padding(2);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(561, 156);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellClick_1);
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);

            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_luu_employee);
            this.groupBox5.Controls.Add(this.btn_capnhat_employee);
            this.groupBox5.Controls.Add(this.txt_salary);
            this.groupBox5.Controls.Add(this.btn_xoa_employee);
            this.groupBox5.Controls.Add(this.btn_them_employee);
            this.groupBox5.Controls.Add(this.txt_employeename);
            this.groupBox5.Controls.Add(this.txt_employeeid);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(9, 385);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(308, 171);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee";
            // 
            // btn_luu_employee
            // 
            this.btn_luu_employee.Location = new System.Drawing.Point(242, 128);
            this.btn_luu_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu_employee.Name = "btn_luu_employee";
            this.btn_luu_employee.Size = new System.Drawing.Size(56, 19);
            this.btn_luu_employee.TabIndex = 36;
            this.btn_luu_employee.Text = "Lưu";
            this.btn_luu_employee.UseVisualStyleBackColor = true;
            this.btn_luu_employee.Click += new System.EventHandler(this.btn_luu_employee_Click);
            // 
            // btn_capnhat_employee
            // 
            this.btn_capnhat_employee.Location = new System.Drawing.Point(155, 128);
            this.btn_capnhat_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_capnhat_employee.Name = "btn_capnhat_employee";
            this.btn_capnhat_employee.Size = new System.Drawing.Size(71, 19);
            this.btn_capnhat_employee.TabIndex = 31;
            this.btn_capnhat_employee.Text = "Cập nhật";
            this.btn_capnhat_employee.UseVisualStyleBackColor = true;
            this.btn_capnhat_employee.Click += new System.EventHandler(this.btn_capnhat_employee_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(120, 94);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(2);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(157, 20);
            this.txt_salary.TabIndex = 34;
            // 
            // btn_xoa_employee
            // 
            this.btn_xoa_employee.Location = new System.Drawing.Point(82, 128);
            this.btn_xoa_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoa_employee.Name = "btn_xoa_employee";
            this.btn_xoa_employee.Size = new System.Drawing.Size(56, 19);
            this.btn_xoa_employee.TabIndex = 29;
            this.btn_xoa_employee.Text = "Xóa";
            this.btn_xoa_employee.UseVisualStyleBackColor = true;
            this.btn_xoa_employee.Click += new System.EventHandler(this.btn_xoa_employee_Click);
            // 
            // btn_them_employee
            // 
            this.btn_them_employee.Location = new System.Drawing.Point(10, 128);
            this.btn_them_employee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them_employee.Name = "btn_them_employee";
            this.btn_them_employee.Size = new System.Drawing.Size(56, 19);
            this.btn_them_employee.TabIndex = 26;
            this.btn_them_employee.Text = "Thêm";
            this.btn_them_employee.UseVisualStyleBackColor = true;
            this.btn_them_employee.Click += new System.EventHandler(this.btn_them_employee_Click);
            // 
            // txt_employeename
            // 
            this.txt_employeename.Location = new System.Drawing.Point(120, 69);
            this.txt_employeename.Margin = new System.Windows.Forms.Padding(2);
            this.txt_employeename.Name = "txt_employeename";
            this.txt_employeename.Size = new System.Drawing.Size(157, 20);
            this.txt_employeename.TabIndex = 33;
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Location = new System.Drawing.Point(120, 46);
            this.txt_employeeid.Margin = new System.Windows.Forms.Padding(2);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(157, 20);
            this.txt_employeeid.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Employee_ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Salary:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Employee_Name:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgv3);
            this.groupBox6.Location = new System.Drawing.Point(336, 385);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(566, 171);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin chi tiết";
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(0, 17);
            this.dgv3.Margin = new System.Windows.Forms.Padding(2);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(561, 148);
            this.dgv3.TabIndex = 0;
            this.dgv3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellClick);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.sQLQuery_ABCDataSet3;
            // 
            // sQLQuery_ABCDataSet3
            // 
            this.sQLQuery_ABCDataSet3.DataSetName = "SQLQuery_ABCDataSet3";
            this.sQLQuery_ABCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.sQLQuery_ABCDataSet2;
            // 
            // sQLQuery_ABCDataSet2
            // 
            this.sQLQuery_ABCDataSet2.DataSetName = "SQLQuery_ABCDataSet2";
            this.sQLQuery_ABCDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // sQLQuery_ABCDataSet1
            // 
            this.sQLQuery_ABCDataSet1.DataSetName = "SQLQuery_ABCDataSet1";
            this.sQLQuery_ABCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.sQLQuery_ABCDataSet1;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 566);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery_ABCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
     

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_capnhat_product;
        private System.Windows.Forms.Button btn_xoa_product;
        private System.Windows.Forms.Button btn_them_product;
        private System.Windows.Forms.TextBox txt_storagelocation;
        private System.Windows.Forms.TextBox txt_stockquantity;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_capnhat_order;
        private System.Windows.Forms.Button btn_xoa_order;
        private System.Windows.Forms.Button btn_them_order;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.TextBox txt_employee_order;
        private System.Windows.Forms.TextBox txt_productid_order;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_capnhat_employee;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Button btn_xoa_employee;
        private System.Windows.Forms.Button btn_them_employee;
        private System.Windows.Forms.TextBox txt_employeename;
        private System.Windows.Forms.TextBox txt_employeeid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DateTimePicker dtp_orderdate;
        private System.Windows.Forms.Button btn_luu_product;
        private System.Windows.Forms.Button btn_luu_order;
        private System.Windows.Forms.Button btn_luu_employee;
        private SQLQuery_ABCDataSet sQLQuery_ABCDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SQLQuery_ABCDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageLocationDataGridViewTextBoxColumn;
        private SQLQuery_ABCDataSet1 sQLQuery_ABCDataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private SQLQuery_ABCDataSet1TableAdapters.OrderTableAdapter orderTableAdapter;
        private SQLQuery_ABCDataSet2 sQLQuery_ABCDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private SQLQuery_ABCDataSet2TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private SQLQuery_ABCDataSet3 sQLQuery_ABCDataSet3;
        private BindingSource employeeBindingSource1;
        private SQLQuery_ABCDataSet3TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}

