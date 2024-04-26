using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        bool isthem = true;
        private void load()
        {
            dgv1.DataSource = db.Products.ToList();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            load();
        }
        private void btn_add_product_Click(object sender, EventArgs e)
        {
            isthem = true;
        }

        private void btn_capnhat_product_Click(object sender, EventArgs e)
        {
            isthem = false;
        }

        private void btn_luu_product_Click(object sender, EventArgs e)
        {
            if(isthem)
            {
                Product product = new Product();
                product.ProductID = int.Parse(txt_productid.Text);
                product.ProductName = txt_productname.Text;
                product.StockQuantity = int.Parse(txt_stockquantity.Text); 
                product.StorageLocation = txt_storagelocation.Text;
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
                MessageBox.Show("Thành công nha bạn ơi!");
                load();   
            }
            else
            {
                Product product1 = new Product();
                product1 = db.Products.Where(a => a.ProductID == int.Parse(txt_productid.Text)).SingleOrDefault();
                product1.ProductName = txt_productname.Text;
                product1.StockQuantity = int.Parse(txt_stockquantity.Text);
                product1.StorageLocation = txt_storagelocation.Text;
                db.SubmitChanges();
                MessageBox.Show("Thành công nè!");
                load();
            }
        }

        private void btn_xoa_product_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa nhen!","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var product = db.Products.Single(a => a.ProductID == int.Parse(txt_productid.Text));
                db.Products.DeleteOnSubmit(product);
                db.SubmitChanges() ;
                MessageBox.Show("Xóa được roài nè!");
                load();
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv1.RowCount > 0 )
            {
                txt_productid.Text = dgv1[0,dgv1.CurrentRow.Index].Value.ToString();
                txt_productid_order.Text = dgv1[0, dgv1.CurrentRow.Index].Value.ToString();
                txt_productname.Text = dgv1[1, dgv1.CurrentRow.Index].Value.ToString();
                txt_stockquantity.Text = dgv1[2, dgv1.CurrentRow.Index].Value.ToString();
                txt_storagelocation.Text = dgv1[3, dgv1.CurrentRow.Index].Value.ToString();
            }
        }

    }
}
