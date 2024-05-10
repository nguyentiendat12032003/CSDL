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
            dgv2.DataSource = db.Orders.ToList();
            dgv3.DataSource = db.Employees.ToList();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQLQuery_ABCDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.sQLQuery_ABCDataSet3.Employee);
            // TODO: This line of code loads data into the 'sQLQuery_ABCDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.sQLQuery_ABCDataSet2.Employee);
            // TODO: This line of code loads data into the 'sQLQuery_ABCDataSet1.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.sQLQuery_ABCDataSet1.Order);
            // TODO: This line of code loads data into the 'sQLQuery_ABCDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sQLQuery_ABCDataSet.Product);
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
                db.Products.DeleteOnSubmit(product);

                db.SubmitChanges();
                MessageBox.Show("Xóa được roài nè!");
                load();
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv1.RowCount > 0 )
            {
                txt_productid.Text = dgv1[0,dgv1.CurrentRow.Index].Value.ToString();
                txt_productname.Text = dgv1[1, dgv1.CurrentRow.Index].Value.ToString();
                txt_stockquantity.Text = dgv1[2, dgv1.CurrentRow.Index].Value.ToString();
                txt_storagelocation.Text = dgv1[3, dgv1.CurrentRow.Index].Value.ToString();
            }
        }


        private void btn_them_employee_Click(object sender, EventArgs e)
        {
            isthem = true;
        }

        private void btn_xoa_employee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhen!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var employee = db.Employees.Single(a => a.EmployeeID == int.Parse(txt_employeeid.Text));

                db.SubmitChanges();
                MessageBox.Show("Xóa được roài nè!");
                load();
            }
        }

        private void btn_capnhat_employee_Click(object sender, EventArgs e)
        {
            isthem = false;

        }

        private void btn_luu_employee_Click(object sender, EventArgs e)
        {
            if (isthem)
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(txt_employeeid.Text);
                employee.EmployeeName = txt_employeename.Text;
                employee.Salary = int.Parse(txt_salary.Text);
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
                MessageBox.Show("Thành công nha bạn ơi!");
                load();
            }
            else
            {
                Employee employee1 = new Employee();
                employee1 = db.Employees.Where(a => a.EmployeeID == int.Parse(txt_employeeid.Text)).SingleOrDefault();
                employee1.EmployeeName = txt_employeename.Text;
                employee1.Salary = int.Parse(txt_salary.Text);
                db.SubmitChanges();
                MessageBox.Show("Thành công nè!");
                load();
            }
        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv3.RowCount > 0)
            {
                txt_employeeid.Text = dgv3[0, dgv3.CurrentRow.Index].Value.ToString();
                txt_employeename.Text = dgv3[1, dgv3.CurrentRow.Index].Value.ToString();
                txt_salary.Text = dgv3[2, dgv3.CurrentRow.Index].Value.ToString();
            }
        }

    
    }
}
