using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormsUI
{
    public partial class Form1 : Form
    {
        IProductService productService;
        ICategoryService categoryService;
        public Form1()
        {
            InitializeComponent();
            //productService = new ProductManager(new EfProductDal());
            //categoryService = new CategoryManager(new EfCategoryDal());

            productService = InstanceFactory.GetInstance<IProductService>();
            categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ProductManager productManager = new ProductManager(new NhProductDal());//(new EfProductDal());
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            comboBox_Category.DataSource = categoryService.GetAll();
            comboBox_Category.DisplayMember = "CategoryName";
            comboBox_Category.ValueMember = "CategoryId";

            comboBox_Add_Category.DataSource = categoryService.GetAll();
            comboBox_Add_Category.DisplayMember = "CategoryName";
            comboBox_Add_Category.ValueMember = "CategoryId";

            comboBox_Update_Category.DataSource = categoryService.GetAll();
            comboBox_Update_Category.DisplayMember = "CategoryName";
            comboBox_Update_Category.ValueMember = "CategoryId";

        }

        private void LoadProducts()
        {
            dataGridView_Products.DataSource = productService.GetAll();
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Products.DataSource = productService.GetProductsByCategory(Convert.ToInt32(comboBox_Category.SelectedValue));

            }
            catch
            {


            }
        }

        private void textBox_Product_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Product.Text))
            {
                dataGridView_Products.DataSource = productService.GetProductByProductName(textBox_Product.Text);
            }
            else
            {
                LoadProducts();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(comboBox_Add_Category.SelectedValue),
                    ProductName = textBox_ProductName.Text,
                    QuantityPerUnit = textBox_QuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(textBox_UnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(textBox_UnitsInStock.Text)
                });
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dataGridView_Products.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(comboBox_Update_Category.SelectedValue),
                ProductName = textBox_Update_ProductName.Text,
                QuantityPerUnit = textBox_Update_QuantityPerUnit.Text,
                UnitPrice = Convert.ToDecimal(textBox_Update_UnitPrice.Text),
                UnitsInStock = Convert.ToInt16(textBox_Update_UnitsInStock.Text)
            });
            LoadProducts();
        }

        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView_Products.CurrentRow;
            textBox_Update_ProductName.Text = row.Cells[1].Value.ToString();
            comboBox_Update_Category.SelectedValue = row.Cells[2].Value;
            textBox_Update_UnitPrice.Text = row.Cells[3].Value.ToString();
            textBox_Update_QuantityPerUnit.Text = row.Cells[4].Value.ToString();
            textBox_Update_UnitsInStock.Text = row.Cells[5].Value.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            productService.Delete(new Product
            {
                ProductId = Convert.ToInt32(dataGridView_Products.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }
    }
}
