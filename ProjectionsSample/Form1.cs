﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AsyncOperations.Classes;
using AsyncOperations.Components;
using AsyncOperations.Examples;
using AsyncOperations.LanguageExtensions;
using AsyncOperations.Projections;
using Microsoft.EntityFrameworkCore;
using static AsyncOperations.Classes.Dialogs;

namespace AsyncOperations 
{
    public partial class Form1 : Form
    {
        /*
         * Strong type container which provides sorting ability in the DataGridView
         */
        private SortableBindingList<Products> _productView;

        /*
         * Container for DataGridView.DataSource
         */
        private readonly BindingSource _productBindingSource = new BindingSource();

        /*
         * Container for suppliers which is used each time the DataGridView is populated
         * with products from a specific category rather than read them each time the
         * DataSource of the DataGridView changes
         */
        private List<Supplier> _supperList;

        public Form1()
        {
            InitializeComponent();

            ProductsButton.Enabled = false;
            SaveChangesButton.Enabled = false;
            CheckedProductsButton.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;

            Shown += Form1_Shown;

        }
        /// <summary>
        /// * Read in all categories w/o change tracker
        /// * Setup ComboBox column for categories
        /// * Read in suppliers for DataGridView ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Shown(object sender, EventArgs e)
        {

            #if DEBUG
            Console.WriteLine("Loading categories");
            #endif

            var categories = await Operations.GetCategoriesAllProjectionsAsync();
            CategoryComboBox.DataSource = categories;

            SupplierColumn.DisplayMember = "CompanyName";
            SupplierColumn.ValueMember = "SupplierId";
            SupplierColumn.DataPropertyName = "SupplierId";
            SupplierColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            #if DEBUG
            Console.WriteLine();
            Console.WriteLine("Loading Suppliers");
            #endif
            _supperList = await Operations.GetSupplierAsync();

            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            ProductsButton.Enabled = true;
            SaveChangesButton.Enabled = true;
            CheckedProductsButton.Enabled = true;

        }
        /// <summary>
        /// Informational on when the Supplier ComboBox current value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SupplierColumn")
            {
                var currentProduct = _productView[_productBindingSource.Position];
            }
        }

        /// <summary>
        /// * Informational on changes to the current product
        /// * Can be used for validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _productView_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {

                /*
                 * Access deleted products
                 */
                var deleted = Operations.Context.ChangeTracker.Entries()
                    .Where(item => item.State == EntityState.Deleted).Select(item => item.Entity as Products).ToList();

            }

            var currentProduct = _productView[_productBindingSource.Position];

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                // TODO - anything needed say in validation
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                // TODO - anything needed say in validation
            }
        }

        /// <summary>
        /// Do not load all products, only products which belong to the
        /// selected category in the ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ProductsButton_Click(object sender, EventArgs e)
        {
            var categoryIdentifier = ((Category) CategoryComboBox.SelectedItem).CategoryId;

            try
            {
                #if DEBUG
                    Console.WriteLine($"Products for category \"{ CategoryComboBox.Text }\"");
                #endif

                _productView = new SortableBindingList<Products>(await Operations.GetProducts(categoryIdentifier));

                // no products e.g. the Wine category has no products
                if (_productView.Count == 0)
                {
                    
                    _productBindingSource.DataSource = null;

                    MessageBox.Show($"No products for {CategoryComboBox.Text}");

                    return;

                }
                
                _productView.ListChanged += _productView_ListChanged;
                _productBindingSource.DataSource = _productView;
                SupplierColumn.DataSource = _supperList;
                dataGridView1.DataSource = _productBindingSource;

                dataGridView1.ExpandColumns();
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Deleting from the SortableBindingList requires the product state to
        /// be marked as deleted when deleting from the row header of the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) => 
            Operations.Context.Entry(_productView[e.Row.Index]).State = EntityState.Deleted;

        /// <summary>
        /// Save all changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Question("Save changes?"))
                {
                    await Operations.Context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Code for obtaining checked rows in the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedProductsButton_Click(object sender, EventArgs e)
        {
            if (_productView == null)
            {
                return;
            }

            var checkedProducts = _productView.Where(product => product.Process).ToList();

            if (checkedProducts.Count >0)
            {
                var f = new CheckProductsForm(checkedProducts, CategoryComboBox.Text);
                try
                {
                    f.ShowDialog();
                }
                finally
                {
                    f.Dispose();
                }

            }
            else
            {
                MessageBox.Show("No checked products");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e) => Close();
    }
}
