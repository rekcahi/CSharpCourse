using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue.ToString()));
            }
            catch
            {
            }        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();

        }

        private void ListProducts()
        {
            using (NortwindContext context = new NortwindContext())
            {
                dataGridView1.DataSource = context.Products.ToList();
            }
        }

        private void ListProductsByName(string productName)
        {
            using (NortwindContext context = new NortwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(x=>x.ProductName.ToLower().Contains(productName.ToLower())).ToList();
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NortwindContext context = new NortwindContext())
            {
                dataGridView1.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }
        private void ListCategories()
        {
            using (NortwindContext context = new NortwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text;
            try
            {
                if(string.IsNullOrEmpty(key))
                {
                    ListProducts();

                }
                else
                {
                    ListProductsByName(txtSearch.Text);
                }
            
            }
            catch
            {
            }

        }
    }
}
