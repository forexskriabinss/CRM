using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM.Bl.Model;

namespace CRM.Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new CrmContext())
            {
                db.Products.Add(new Product { Name="Sugar"});
                db.SaveChanges();
                var list = db.Products.ToList();
                MessageBox.Show(list.Count.ToString());
            }
                
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
            var item = e.ClickedItem.Text;
            if(e.ClickedItem.IsOnDropDown)
                MessageBox.Show(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
