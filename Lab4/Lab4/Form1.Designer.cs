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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // btn_capnhat_product
            // 
            this.btn_capnhat_product.Location = new System.Drawing.Point(283, 189);
            this.btn_capnhat_product.Name = "btn_capnhat_product";
            this.btn_capnhat_product.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_product.TabIndex = 22;
            this.btn_capnhat_product.Text = "Cập nhật";
            this.btn_capnhat_product.UseVisualStyleBackColor = true;
            // 
            // btn_xoa_product
            // 
            this.btn_xoa_product.Location = new System.Drawing.Point(186, 189);
            this.btn_xoa_product.Name = "btn_xoa_product";
            this.btn_xoa_product.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_product.TabIndex = 21;
            this.btn_xoa_product.Text = "Xóa";
            this.btn_xoa_product.UseVisualStyleBackColor = true;
            // 
            // btn_them_product
            // 
            this.btn_them_product.Location = new System.Drawing.Point(89, 189);
            this.btn_them_product.Name = "btn_them_product";
            this.btn_them_product.Size = new System.Drawing.Size(75, 23);
            this.btn_them_product.TabIndex = 20;
            this.btn_them_product.Text = "Thêm";
            this.btn_them_product.UseVisualStyleBackColor = true;
            this.btn_them_product.Click += new System.EventHandler(this.btn_them_product_Click);
            // 
            // txt_storagelocation
            // 
            this.txt_storagelocation.Location = new System.Drawing.Point(170, 127);
            this.txt_storagelocation.Name = "txt_storagelocation";
            this.txt_storagelocation.Size = new System.Drawing.Size(204, 22);
            this.txt_storagelocation.TabIndex = 19;
            // 
            // txt_stockquantity
            // 
            this.txt_stockquantity.Location = new System.Drawing.Point(170, 97);
            this.txt_stockquantity.Name = "txt_stockquantity";
            this.txt_stockquantity.Size = new System.Drawing.Size(204, 22);
            this.txt_stockquantity.TabIndex = 18;
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(170, 67);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(204, 22);
            this.txt_productname.TabIndex = 17;
            // 
            // txt_productid
            // 
            this.txt_productid.Location = new System.Drawing.Point(170, 37);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(204, 22);
            this.txt_productid.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Storage_Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stock_Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product_Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product_ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 204);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(431, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 227);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // dtp_orderdate
            // 
            this.dtp_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate.Location = new System.Drawing.Point(179, 172);
            this.dtp_orderdate.Name = "dtp_orderdate";
            this.dtp_orderdate.Size = new System.Drawing.Size(208, 22);
            this.dtp_orderdate.TabIndex = 35;
            // 
            // btn_capnhat_order
            // 
            this.btn_capnhat_order.Location = new System.Drawing.Point(261, 200);
            this.btn_capnhat_order.Name = "btn_capnhat_order";
            this.btn_capnhat_order.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_order.TabIndex = 28;
            this.btn_capnhat_order.Text = "Cập nhật";
            this.btn_capnhat_order.UseVisualStyleBackColor = true;
            // 
            // btn_xoa_order
            // 
            this.btn_xoa_order.Location = new System.Drawing.Point(164, 200);
            this.btn_xoa_order.Name = "btn_xoa_order";
            this.btn_xoa_order.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_order.TabIndex = 26;
            this.btn_xoa_order.Text = "Xóa";
            this.btn_xoa_order.UseVisualStyleBackColor = true;
            // 
            // btn_them_order
            // 
            this.btn_them_order.Location = new System.Drawing.Point(67, 200);
            this.btn_them_order.Name = "btn_them_order";
            this.btn_them_order.Size = new System.Drawing.Size(75, 23);
            this.btn_them_order.TabIndex = 24;
            this.btn_them_order.Text = "Thêm";
            this.btn_them_order.UseVisualStyleBackColor = true;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(179, 144);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(208, 22);
            this.txt_quantity.TabIndex = 34;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(179, 116);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(208, 22);
            this.txt_customername.TabIndex = 33;
            // 
            // txt_employee_order
            // 
            this.txt_employee_order.Location = new System.Drawing.Point(179, 88);
            this.txt_employee_order.Name = "txt_employee_order";
            this.txt_employee_order.Size = new System.Drawing.Size(208, 22);
            this.txt_employee_order.TabIndex = 32;
            // 
            // txt_productid_order
            // 
            this.txt_productid_order.Location = new System.Drawing.Point(178, 60);
            this.txt_productid_order.Name = "txt_productid_order";
            this.txt_productid_order.Size = new System.Drawing.Size(208, 22);
            this.txt_productid_order.TabIndex = 31;
            // 
            // txt_orderid
            // 
            this.txt_orderid.Location = new System.Drawing.Point(179, 32);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(208, 22);
            this.txt_orderid.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Customer_Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Order_ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Employee_ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Product_ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(431, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 204);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(410, 192);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_capnhat_employee);
            this.groupBox5.Controls.Add(this.txt_salary);
            this.groupBox5.Controls.Add(this.btn_xoa_employee);
            this.groupBox5.Controls.Add(this.btn_them_employee);
            this.groupBox5.Controls.Add(this.txt_employeename);
            this.groupBox5.Controls.Add(this.txt_employeeid);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(848, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 227);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee";
            // 
            // btn_capnhat_employee
            // 
            this.btn_capnhat_employee.Location = new System.Drawing.Point(257, 184);
            this.btn_capnhat_employee.Name = "btn_capnhat_employee";
            this.btn_capnhat_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_employee.TabIndex = 31;
            this.btn_capnhat_employee.Text = "Cập nhật";
            this.btn_capnhat_employee.UseVisualStyleBackColor = true;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(160, 116);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(208, 22);
            this.txt_salary.TabIndex = 34;
            // 
            // btn_xoa_employee
            // 
            this.btn_xoa_employee.Location = new System.Drawing.Point(160, 184);
            this.btn_xoa_employee.Name = "btn_xoa_employee";
            this.btn_xoa_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_employee.TabIndex = 29;
            this.btn_xoa_employee.Text = "Xóa";
            this.btn_xoa_employee.UseVisualStyleBackColor = true;
            // 
            // btn_them_employee
            // 
            this.btn_them_employee.Location = new System.Drawing.Point(63, 184);
            this.btn_them_employee.Name = "btn_them_employee";
            this.btn_them_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_them_employee.TabIndex = 26;
            this.btn_them_employee.Text = "Thêm";
            this.btn_them_employee.UseVisualStyleBackColor = true;
            // 
            // txt_employeename
            // 
            this.txt_employeename.Location = new System.Drawing.Point(160, 85);
            this.txt_employeename.Name = "txt_employeename";
            this.txt_employeename.Size = new System.Drawing.Size(208, 22);
            this.txt_employeename.TabIndex = 33;
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Location = new System.Drawing.Point(160, 57);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(208, 22);
            this.txt_employeeid.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Employee_ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Salary:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Employee_Name:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView3);
            this.groupBox6.Location = new System.Drawing.Point(848, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(384, 204);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin chi tiết";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(384, 182);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vị trí";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 459);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

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
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DateTimePicker dtp_orderdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

