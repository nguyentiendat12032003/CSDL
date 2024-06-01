using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab4_v2
{
    public partial class Form1 : Form
    {
        Product product = new Product();
        Order order = new Order();
        OrdersDetail ordersDetail = new OrdersDetail();
   

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            var pro = (from s in db.Products select s).ToList();
            dgv1.DataSource = pro;
            txt_productid.DataBindings.Clear();
            txt_productname.DataBindings.Clear();
            txt_unitprice.DataBindings.Clear();
            txt_stock.DataBindings.Clear();
            txt_productid.DataBindings.Add("text", pro, "ProductID");
            txt_productname.DataBindings.Add("text", pro, "ProductName");
            txt_unitprice.DataBindings.Add("text", pro, "UnitPrice");
            txt_stock.DataBindings.Add("text", pro, "Stock");
            //----------------Order--------------------
            var ord = (from s in db.Orders select s).ToList();
            dgv3.DataSource = ord;
            txt_orderid.DataBindings.Clear();
            dtp_orderdate.DataBindings.Clear();
            txt_cusname.DataBindings.Clear();
            txt_address.DataBindings.Clear();
            txt_orderid.DataBindings.Add("text", ord, "OrderID");
            dtp_orderdate.DataBindings.Add("text", ord, "OrderDate");
            txt_cusname.DataBindings.Add("text", ord, "CustomerName");
            txt_address.DataBindings.Add("text", ord, "CustomerAddress");
            //----------------Order Details---------------------------
            var ordde = (from s in db.OrdersDetails select s).ToList();
            dgv2.DataSource = ordde;
            txt_ord_detailID.DataBindings.Clear();
            txt_ordde_orderID.DataBindings.Clear();
            txt_ordde_productID.DataBindings.Clear();
            txt_quantity.DataBindings.Clear();
            txt_ordde_price.DataBindings.Clear();
            txt_ord_detailID.DataBindings.Add("text", ordde, "OrderDetailID");
            txt_ordde_orderID.DataBindings.Add("text", ordde, "OrderID");
            txt_ordde_productID.DataBindings.Add("text", ordde, "ProductID");
            txt_quantity.DataBindings.Add("text", ordde, "Quantity");
            txt_ordde_price.DataBindings.Add("text", ordde, "UnitPrice");



        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            product.ProductName = txt_productname.Text;
            product.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            product.Stock = Int32.Parse(txt_stock.Text);
            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();
            Form1_Load(sender, e);

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            product = db.Products.Where(s => s.ProductID == Int32.Parse(txt_productid.Text)).Single();
            product.ProductName = txt_productname.Text;
            product.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            product.Stock = Int32.Parse(txt_stock.Text);
            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();

            // Find the product to delete
            product = db.Products.Where(s => s.ProductID == Int32.Parse(txt_productid.Text)).Single();

            // Delete related order details
            var relatedOrderDetails = db.OrdersDetails.Where(od => od.ProductID == product.ProductID);
            db.OrdersDetails.DeleteAllOnSubmit(relatedOrderDetails);

            // Delete the product
            db.Products.DeleteOnSubmit(product);

            // Commit changes to the database
            db.SubmitChanges();

            // Refresh the form
            Form1_Load(sender, e);
        }
        //----------------------Order---------------------------
         private void btn_themorder_Click(object sender, EventArgs e)
            {
                DataDataContext db = new DataDataContext();
                order.OrderDate = DateTime.Parse(dtp_orderdate.Text);
                order.CustomerName = txt_cusname.Text;
                order.CustomerAddress = txt_address.Text;
                db.Orders.InsertOnSubmit(order);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }

        private void btn_xoaorder_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();

            // Fetch the order to be deleted
            int orderId = Int32.Parse(txt_orderid.Text);
            order = db.Orders.Where(s => s.OrderID == orderId).Single();

            // Delete related order details first
            var orderDetails = db.OrdersDetails.Where(od => od.OrderID == orderId).ToList();
            db.OrdersDetails.DeleteAllOnSubmit(orderDetails);

            // Delete the order
            db.Orders.DeleteOnSubmit(order);

            // Submit changes
            db.SubmitChanges();

            // Refresh the form
            Form1_Load(sender, e);
        }

        private void btn_capnhatorder_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            order = db.Orders.Where(s => s.OrderID == Int32.Parse(txt_orderid.Text)).Single();
            order.OrderID = Int32.Parse(txt_orderid.Text);
            order.OrderDate = DateTime.Parse(dtp_orderdate.Text);
            order.CustomerName = txt_cusname.Text;
            order.CustomerAddress = txt_address.Text;
            db.SubmitChanges();
            Form1_Load(sender, e);
        }

        private void btn_them_od_Click(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            ordersDetail.OrderID = Int32.Parse(txt_ord_detailID.Text);
            ordersDetail.ProductID = Int32.Parse(txt_ordde_productID.Text);
            ordersDetail.Quantity = Int32.Parse(txt_quantity.Text);
            ordersDetail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);  
            db.OrdersDetails.InsertOnSubmit(ordersDetail);
            db.SubmitChanges();
            Form1_Load(sender, e);
        }
    }
    }


