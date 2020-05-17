using System;
using System.Threading.Tasks;
using static AsyncOperations.Classes.Dialogs;
using System.Windows.Forms;
using AsyncOperations.Classes;

namespace AsyncOperations.Examples
{
    public partial class ExamplesForm : Form
    {

        public ExamplesForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Best, only load what's needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadProjectsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Category async projections");
            var categories = await Operations.GetCategoriesAllProjectionsAsync();
            CategoryProjectionsAsynComboBox.DataSource = categories;
            Console.WriteLine();
        }
        /// <summary>
        /// Loads more properties than needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadWithoutProjectsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Category sync no projections");
            var categories = await Operations.GetCategoriesAllNoProjectionsAsync();
            CategoryNoProjectionsAsynComboBox.DataSource = categories;
            Console.WriteLine();
        }
        /// <summary>
        /// Potentially freezes for a few seconds if this is the first read via EF Core.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConventionalLoadButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Category async without projections");
            var categories = Operations.GetCategoriesAllNotTracked();
            CategoryConventionalComboBox.DataSource = categories;
            Console.WriteLine();
        }

        private async void OrdersButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Orders");
            var order = await Operations.GetOrders1(10);
            Console.WriteLine();
        }

        private async void ProductProjectionButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Products");
            var productsWithProjection = await Operations.GetProductsWithProjection(1, false);
            Console.WriteLine();
        }

        private void ConventionalProjectionsLoadButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Category async with projections");
            var categories = Operations.GetCategoriesAllNotTrackedProjections();
            CategoryConventionalProjectionsComboBox.DataSource = categories;
            Console.WriteLine();

        }

        private void TypicalLoadButton_Click(object sender, EventArgs e)
        {
            var categories = Operations.Simple();
            TypicalComboBox.DisplayMember = "CategoryName";
            TypicalComboBox.ValueMember = "CategoryId";
            TypicalComboBox.DataSource = Operations.Simple();
        }
    }
}
