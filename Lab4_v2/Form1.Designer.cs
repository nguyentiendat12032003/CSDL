namespace Lab4_v2
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
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_capnhatorder = new System.Windows.Forms.Button();
            this.btn_xoaorder = new System.Windows.Forms.Button();
            this.dtp_orderdate = new System.Windows.Forms.DateTimePicker();
            this.btn_themorder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cusname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.txt_ord_detailID = new System.Windows.Forms.TextBox();
            this.txt_ordde_orderID = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_ordde_productID = new System.Windows.Forms.TextBox();
            this.txt_ordde_price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_them_od = new System.Windows.Forms.Button();
            this.btn_xoa_od = new System.Windows.Forms.Button();
            this.btn_capnhat_od = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_unitprice);
            this.groupBox1.Controls.Add(this.txt_productname);
            this.groupBox1.Controls.Add(this.txt_productid);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products (Đạt)";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(180, 143);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(101, 23);
            this.btn_capnhat.TabIndex = 10;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(99, 143);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(12, 143);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(99, 105);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(174, 22);
            this.txt_stock.TabIndex = 3;
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Location = new System.Drawing.Point(99, 77);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(174, 22);
            this.txt_unitprice.TabIndex = 2;
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(99, 49);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(174, 22);
            this.txt_productname.TabIndex = 1;
            // 
            // txt_productid
            // 
            this.txt_productid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_productid.Location = new System.Drawing.Point(99, 21);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.ReadOnly = true;
            this.txt_productid.Size = new System.Drawing.Size(174, 22);
            this.txt_productid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.dgv3);
            this.groupBox2.Controls.Add(this.btn_capnhatorder);
            this.groupBox2.Controls.Add(this.btn_xoaorder);
            this.groupBox2.Controls.Add(this.dtp_orderdate);
            this.groupBox2.Controls.Add(this.btn_themorder);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_cusname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_orderid);
            this.groupBox2.Location = new System.Drawing.Point(816, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders (Quân)";
            // 
            // btn_capnhatorder
            // 
            this.btn_capnhatorder.Location = new System.Drawing.Point(184, 143);
            this.btn_capnhatorder.Name = "btn_capnhatorder";
            this.btn_capnhatorder.Size = new System.Drawing.Size(95, 23);
            this.btn_capnhatorder.TabIndex = 13;
            this.btn_capnhatorder.Text = "Cập nhật";
            this.btn_capnhatorder.UseVisualStyleBackColor = true;
            this.btn_capnhatorder.Click += new System.EventHandler(this.btn_capnhatorder_Click);
            // 
            // btn_xoaorder
            // 
            this.btn_xoaorder.Location = new System.Drawing.Point(103, 143);
            this.btn_xoaorder.Name = "btn_xoaorder";
            this.btn_xoaorder.Size = new System.Drawing.Size(75, 23);
            this.btn_xoaorder.TabIndex = 12;
            this.btn_xoaorder.Text = "Xóa";
            this.btn_xoaorder.UseVisualStyleBackColor = true;
            this.btn_xoaorder.Click += new System.EventHandler(this.btn_xoaorder_Click);
            // 
            // dtp_orderdate
            // 
            this.dtp_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate.Location = new System.Drawing.Point(105, 48);
            this.dtp_orderdate.Name = "dtp_orderdate";
            this.dtp_orderdate.Size = new System.Drawing.Size(174, 22);
            this.dtp_orderdate.TabIndex = 15;
            // 
            // btn_themorder
            // 
            this.btn_themorder.Location = new System.Drawing.Point(16, 143);
            this.btn_themorder.Name = "btn_themorder";
            this.btn_themorder.Size = new System.Drawing.Size(75, 23);
            this.btn_themorder.TabIndex = 11;
            this.btn_themorder.Text = "Thêm";
            this.btn_themorder.UseVisualStyleBackColor = true;
            this.btn_themorder.Click += new System.EventHandler(this.btn_themorder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(105, 105);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(174, 22);
            this.txt_address.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // txt_cusname
            // 
            this.txt_cusname.Location = new System.Drawing.Point(105, 77);
            this.txt_cusname.Name = "txt_cusname";
            this.txt_cusname.Size = new System.Drawing.Size(174, 22);
            this.txt_cusname.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID";
            // 
            // txt_orderid
            // 
            this.txt_orderid.Location = new System.Drawing.Point(105, 21);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.ReadOnly = true;
            this.txt_orderid.Size = new System.Drawing.Size(174, 22);
            this.txt_orderid.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Controls.Add(this.btn_capnhat_od);
            this.groupBox3.Controls.Add(this.btn_xoa_od);
            this.groupBox3.Controls.Add(this.btn_them_od);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_ordde_price);
            this.groupBox3.Controls.Add(this.txt_ordde_productID);
            this.groupBox3.Controls.Add(this.txt_quantity);
            this.groupBox3.Controls.Add(this.txt_ordde_orderID);
            this.groupBox3.Controls.Add(this.txt_ord_detailID);
            this.groupBox3.Location = new System.Drawing.Point(23, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1512, 112);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Details (Tuấn)";
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(23, 222);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(1512, 209);
            this.dgv2.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(302, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(485, 185);
            this.dgv1.TabIndex = 3;
            // 
            // dgv3
            // 
            this.dgv3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(298, 0);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 51;
            this.dgv3.RowTemplate.Height = 24;
            this.dgv3.Size = new System.Drawing.Size(421, 185);
            this.dgv3.TabIndex = 4;
            // 
            // txt_ord_detailID
            // 
            this.txt_ord_detailID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ord_detailID.Location = new System.Drawing.Point(52, 52);
            this.txt_ord_detailID.Name = "txt_ord_detailID";
            this.txt_ord_detailID.Size = new System.Drawing.Size(119, 22);
            this.txt_ord_detailID.TabIndex = 11;
            // 
            // txt_ordde_orderID
            // 
            this.txt_ordde_orderID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ordde_orderID.Location = new System.Drawing.Point(256, 52);
            this.txt_ordde_orderID.Name = "txt_ordde_orderID";
            this.txt_ordde_orderID.Size = new System.Drawing.Size(154, 22);
            this.txt_ordde_orderID.TabIndex = 12;
            // 
            // txt_quantity
            // 
            this.txt_quantity.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_quantity.Location = new System.Drawing.Point(744, 52);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(154, 22);
            this.txt_quantity.TabIndex = 13;
            // 
            // txt_ordde_productID
            // 
            this.txt_ordde_productID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ordde_productID.Location = new System.Drawing.Point(507, 52);
            this.txt_ordde_productID.Name = "txt_ordde_productID";
            this.txt_ordde_productID.Size = new System.Drawing.Size(154, 22);
            this.txt_ordde_productID.TabIndex = 13;
            // 
            // txt_ordde_price
            // 
            this.txt_ordde_price.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_ordde_price.Location = new System.Drawing.Point(990, 52);
            this.txt_ordde_price.Name = "txt_ordde_price";
            this.txt_ordde_price.Size = new System.Drawing.Size(154, 22);
            this.txt_ordde_price.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Order ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Product ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(675, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(912, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Unit Price";
            // 
            // btn_them_od
            // 
            this.btn_them_od.Location = new System.Drawing.Point(1158, 52);
            this.btn_them_od.Name = "btn_them_od";
            this.btn_them_od.Size = new System.Drawing.Size(75, 23);
            this.btn_them_od.TabIndex = 16;
            this.btn_them_od.Text = "Thêm";
            this.btn_them_od.UseVisualStyleBackColor = true;
            this.btn_them_od.Click += new System.EventHandler(this.btn_them_od_Click);
            // 
            // btn_xoa_od
            // 
            this.btn_xoa_od.Location = new System.Drawing.Point(1247, 52);
            this.btn_xoa_od.Name = "btn_xoa_od";
            this.btn_xoa_od.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa_od.TabIndex = 16;
            this.btn_xoa_od.Text = "Xóa";
            this.btn_xoa_od.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat_od
            // 
            this.btn_capnhat_od.Location = new System.Drawing.Point(1336, 52);
            this.btn_capnhat_od.Name = "btn_capnhat_od";
            this.btn_capnhat_od.Size = new System.Drawing.Size(95, 23);
            this.btn_capnhat_od.TabIndex = 16;
            this.btn_capnhat_od.Text = "Cập nhật";
            this.btn_capnhat_od.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1600, 553);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_cusname;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_orderdate;
        private System.Windows.Forms.Button btn_capnhatorder;
        private System.Windows.Forms.Button btn_xoaorder;
        private System.Windows.Forms.Button btn_themorder;
        private System.Windows.Forms.TextBox txt_ord_detailID;
        private System.Windows.Forms.Button btn_capnhat_od;
        private System.Windows.Forms.Button btn_xoa_od;
        private System.Windows.Forms.Button btn_them_od;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ordde_price;
        private System.Windows.Forms.TextBox txt_ordde_productID;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_ordde_orderID;
    }
}

