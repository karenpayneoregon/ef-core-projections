using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleLoggingExample.Models;
using ConsoleLoggingExample.Projections;
using static ConsoleLoggingExample.Classes.Operations;

namespace ConsoleLoggingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetProductsButton.Enabled = false;
            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            await Task.Delay(100);

            var categories =  await GetCategoriesAllProjectionsAsync();
            CategoryListBox.DataSource = categories;
            GetProductsButton.Enabled = true;

        }
        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            var categoryIdentifier = ((Category)CategoryListBox.SelectedItem).CategoryId;
            var productList = await GetProducts(categoryIdentifier);
            MessageBox.Show($"Products count: {productList.Count}");

        }
    }
}
