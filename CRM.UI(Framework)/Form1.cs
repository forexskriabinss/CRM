using System;
using System.Windows.Forms;
using CRM.Model;

namespace CRM.UI_Framework_
{
    public partial class Form1 : Form
    {
        private CrmContext db;

        public Form1()
        {
            InitializeComponent();
            db = new CrmContext();

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCatalog = new Catalog<Product>(db.Products);
            productCatalog.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog<Customer> catalog = new Catalog<Customer>(db.Customers);
            catalog.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog<Seller> catalog = new Catalog<Seller>(db.Sellers);
            catalog.Show();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog<Receipt> catalog = new Catalog<Receipt>(db.Receipts);
            catalog.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new CustomerForm();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    db.Customers.Add(form.Customer);
            //    db.SaveChanges();
            //}
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

       
    }
}
