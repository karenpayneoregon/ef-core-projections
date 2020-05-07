using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AsyncOperations.Examples
{
    public partial class CheckProductsForm : Form
    {
        private List<Products> _products;
        private string _categoryName;
        public CheckProductsForm(List<Products> products, string categoryName)
        {
            InitializeComponent();

            _products = products;

            Shown += CheckProductsForm_Shown;
            dataGridView1.AutoGenerateColumns = false;
            _categoryName = categoryName;
        }

        private void CheckProductsForm_Shown(object sender, EventArgs e)
        {
            Text = $@"Products for '{_categoryName}'";
            dataGridView1.DataSource = _products;
        }
    }
}
