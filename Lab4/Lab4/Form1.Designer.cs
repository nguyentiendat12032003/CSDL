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
            this.Product = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_stockquantity = new System.Windows.Forms.TextBox();
            this.txt_storagelocation = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.txt_productid_order = new System.Windows.Forms.TextBox();
            this.txt_employee_order = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            this.txt_employeename = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_delete_product = new System.Windows.Forms.Button();
            this.btn_capnhat_product = new System.Windows.Forms.Button();
            this.btn_capnhat_order = new System.Windows.Forms.Button();
            this.btn_xoa_order = new System.Windows.Forms.Button();
            this.btn_them_order = new System.Windows.Forms.Button();
            this.btn_capnhat_employee = new System.Windows.Forms.Button();
            this.btn_xoa_employee = new System.Windows.Forms.Button();
            this.btn_them_employee = new System.Windows.Forms.Button();
            this.Product.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.Controls.Add(this.btn_capnhat_product);
            this.Product.Controls.Add(this.btn_delete_product);
            this.Product.Controls.Add(this.btn_add_product);
            this.Product.Controls.Add(this.dataGridView1);
            this.Product.Controls.Add(this.txt_storagelocation);
            this.Product.Controls.Add(this.txt_stockquantity);
            this.Product.Controls.Add(this.txt_productname);
            this.Product.Controls.Add(this.txt_productid);
            this.Product.Controls.Add(this.label4);
            this.Product.Controls.Add(this.label3);
            this.Product.Controls.Add(this.label2);
            this.Product.Controls.Add(this.label1);
            this.Product.Location = new System.Drawing.Point(12, 12);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(386, 433);
            this.Product.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock_Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product_ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_capnhat_order);
            this.panel2.Controls.Add(this.btn_xoa_order);
            this.panel2.Controls.Add(this.txt_date);
            this.panel2.Controls.Add(this.btn_them_order);
            this.panel2.Controls.Add(this.txt_quantity);
            this.panel2.Controls.Add(this.txt_customername);
            this.panel2.Controls.Add(this.txt_employee_order);
            this.panel2.Controls.Add(this.txt_productid_order);
            this.panel2.Controls.Add(this.txt_orderid);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(430, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 433);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_capnhat_employee);
            this.panel3.Controls.Add(this.txt_salary);
            this.panel3.Controls.Add(this.btn_xoa_employee);
            this.panel3.Controls.Add(this.btn_them_employee);
            this.panel3.Controls.Add(this.txt_employeename);
            this.panel3.Controls.Add(this.txt_employeeid);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(847, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 430);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Storage_Location:";
            // 
            // txt_productid
            // 
            this.txt_productid.Location = new System.Drawing.Point(137, 20);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.Size = new System.Drawing.Size(204, 22);
            this.txt_productid.TabIndex = 4;
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(137, 50);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(204, 22);
            this.txt_productname.TabIndex = 5;
            // 
            // txt_stockquantity
            // 
            this.txt_stockquantity.Location = new System.Drawing.Point(137, 80);
            this.txt_stockquantity.Name = "txt_stockquantity";
            this.txt_stockquantity.Size = new System.Drawing.Size(204, 22);
            this.txt_stockquantity.TabIndex = 6;
            // 
            // txt_storagelocation
            // 
            this.txt_storagelocation.Location = new System.Drawing.Point(137, 110);
            this.txt_storagelocation.Name = "txt_storagelocation";
            this.txt_storagelocation.Size = new System.Drawing.Size(204, 22);
            this.txt_storagelocation.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(379, 211);
            this.dataGridView1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer_Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee_ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Product_ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Order_ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(379, 211);
            this.dataGridView2.TabIndex = 9;
            // 
            // txt_orderid
            // 
            this.txt_orderid.Location = new System.Drawing.Point(155, 10);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(208, 22);
            this.txt_orderid.TabIndex = 15;
            // 
            // txt_productid_order
            // 
            this.txt_productid_order.Location = new System.Drawing.Point(154, 38);
            this.txt_productid_order.Name = "txt_productid_order";
            this.txt_productid_order.Size = new System.Drawing.Size(208, 22);
            this.txt_productid_order.TabIndex = 16;
            // 
            // txt_employee_order
            // 
            this.txt_employee_order.Location = new System.Drawing.Point(155, 66);
            this.txt_employee_order.Name = "txt_employee_order";
            this.txt_employee_order.Size = new System.Drawing.Size(208, 22);
            this.txt_employee_order.TabIndex = 17;
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(155, 94);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(208, 22);
            this.txt_customername.TabIndex = 18;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(155, 122);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(208, 22);
            this.txt_quantity.TabIndex = 19;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(155, 150);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(208, 22);
            this.txt_date.TabIndex = 20;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 219);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(379, 211);
            this.dataGridView3.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Employee_ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Salary:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Employee_Name:";
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Location = new System.Drawing.Point(146, 7);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(208, 22);
            this.txt_employeeid.TabIndex = 21;
            // 
            // txt_employeename
            // 
            this.txt_employeename.Location = new System.Drawing.Point(146, 35);
            this.txt_employeename.Name = "txt_employeename";
            this.txt_employeename.Size = new System.Drawing.Size(208, 22);
            this.txt_employeename.TabIndex = 24;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(146, 66);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(208, 22);
            this.txt_salary.TabIndex = 25;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(56, 172);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(75, 23);
            this.btn_add_product.TabIndex = 9;
            this.btn_add_product.Text = "Thêm";
            this.btn_add_product.UseVisualStyleBackColor = true;
            // 
            // btn_delete_product
            // 
            this.btn_delete_product.Location = new System.Drawing.Point(153, 172);
            this.btn_delete_product.Name = "btn_delete_product";
            this.btn_delete_product.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_product.TabIndex = 10;
            this.btn_delete_product.Text = "Xóa";
            this.btn_delete_product.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_product
            // 
            this.btn_capnhat_product.Location = new System.Drawing.Point(250, 172);
            this.btn_capnhat_product.Name = "btn_capnhat_product";
            this.btn_capnhat_product.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_product.TabIndex = 11;
            this.btn_capnhat_product.Text = "Cập nhật";
            this.btn_capnhat_product.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_order
            // 
            this.btn_capnhat_order.Location = new System.Drawing.Point(237, 178);
            this.btn_capnhat_order.Name = "btn_capnhat_order";
            this.btn_capnhat_order.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_order.TabIndex = 14;
            this.btn_capnhat_order.Text = "Cập nhật";
            this.btn_capnhat_order.UseVisualStyleBackColor = true;
            // 
            // btn_xoa_order
            // 
            this.btn_xoa_order.Location = new System.Drawing.Point(140, 178);
            this.btn_xoa_order.Name = "btn_xoa_order";
            this.btn_xoa_order.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_order.TabIndex = 13;
            this.btn_xoa_order.Text = "Xóa";
            this.btn_xoa_order.UseVisualStyleBackColor = true;
            // 
            // btn_them_order
            // 
            this.btn_them_order.Location = new System.Drawing.Point(43, 178);
            this.btn_them_order.Name = "btn_them_order";
            this.btn_them_order.Size = new System.Drawing.Size(75, 23);
            this.btn_them_order.TabIndex = 12;
            this.btn_them_order.Text = "Thêm";
            this.btn_them_order.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_employee
            // 
            this.btn_capnhat_employee.Location = new System.Drawing.Point(243, 172);
            this.btn_capnhat_employee.Name = "btn_capnhat_employee";
            this.btn_capnhat_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat_employee.TabIndex = 23;
            this.btn_capnhat_employee.Text = "Cập nhật";
            this.btn_capnhat_employee.UseVisualStyleBackColor = true;
            // 
            // btn_xoa_employee
            // 
            this.btn_xoa_employee.Location = new System.Drawing.Point(146, 172);
            this.btn_xoa_employee.Name = "btn_xoa_employee";
            this.btn_xoa_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_employee.TabIndex = 22;
            this.btn_xoa_employee.Text = "Xóa";
            this.btn_xoa_employee.UseVisualStyleBackColor = true;
            // 
            // btn_them_employee
            // 
            this.btn_them_employee.Location = new System.Drawing.Point(49, 172);
            this.btn_them_employee.Name = "btn_them_employee";
            this.btn_them_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_them_employee.TabIndex = 21;
            this.btn_them_employee.Text = "Thêm";
            this.btn_them_employee.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Product);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_storagelocation;
        private System.Windows.Forms.TextBox txt_stockquantity;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.TextBox txt_employee_order;
        private System.Windows.Forms.TextBox txt_productid_order;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_capnhat_product;
        private System.Windows.Forms.Button btn_delete_product;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_employeename;
        private System.Windows.Forms.TextBox txt_employeeid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_capnhat_order;
        private System.Windows.Forms.Button btn_xoa_order;
        private System.Windows.Forms.Button btn_them_order;
        private System.Windows.Forms.Button btn_capnhat_employee;
        private System.Windows.Forms.Button btn_xoa_employee;
        private System.Windows.Forms.Button btn_them_employee;
    }
}

