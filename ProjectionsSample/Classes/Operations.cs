using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncOperations.ModelExtensions;
using AsyncOperations.Projections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace AsyncOperations.Classes
{
    public class Operations
    {
        public static NorthWindContext Context { get; } = new NorthWindContext(log: true);

        /// <summary>
        /// Get all categories suitable for displaying in a ComboBox or
        /// ListBox for reference only with only properties needed e.g.
        /// primary key and product name
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Category>> GetCategoriesAllProjectionsAsync()
        {
            
            var categoryList = new List<Category>();

            await Task.Run(async () =>
            {

                categoryList = await Context.Categories
                    .AsNoTracking().Select(Category.Projection)
                    .ToListAsync();

            });

            return categoryList;

        }

        public static List<Categories> Simple()
        {
            return Context.Categories.Include(category => category.Products).ToList();
        }

        /// <summary>
        /// Get all categories suitable for displaying in a ComboBox or
        /// ListBox for reference only but unlike above will have all properties
        /// of Categories table.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Categories>> GetCategoriesAllNoProjectionsAsync() 
        {
            var categoryList = new List<Categories>();

            await Task.Run(async () =>
            {

                categoryList = await Context.Categories
                    .AsNoTracking()
                    .ToListAsync();

            });

            return categoryList;

        }
        public static List<Categories> GetCategoriesAllNotTracked()
        {

            return Context.Categories
                .AsNoTracking()
                .ToList();

        }
        public static List<Category> GetCategoriesAllNotTrackedProjections()
        {

            return Context.Categories
                .AsNoTracking()
                .Select(Category.Projection)
                .ToList();

        }
        public static List<Categories> GetCategoriesAllTracked()
        {
            return Context.Categories
                .ToList();
        }

        /// <summary>
        /// Get list of supplier which is assigned to a private form variable
        /// and used when products for a specific category are selected in the form.
        ///
        /// Note the use of a Project for selecting suppliers in the select part
        /// of the lambda statement.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Supplier>> GetSupplierAsync() 
        {
            var supplierList = new List<Supplier>(); 

            await Task.Run(async () =>
            {

                supplierList = await Context.Suppliers
                    .AsNoTracking()
                    .Select(Supplier.Projection)
                    .ToListAsync();

            });

            return supplierList;
        }

        public static async Task<List<Products>> GetProducts(int categoryIdentifier, bool throwException = false)
        {
            var productList = new List<Products>();

            await Task.Run(async () =>
            {

                if (throwException)
                {
                    var lines = File.ReadAllLines("SomeNonExistingFile.txt");
                }

                productList = await Context.Products
                    .Include(product => product.Supplier)
                    .Where(product => product.CategoryId == categoryIdentifier)
                    .ToListAsync();

            });

            return productList;
        }
        /// <summary>
        /// Example for retrieving products via nested projection
        /// </summary>
        /// <param name="categoryIdentifier"></param>
        /// <returns></returns>
        public static async Task<List<Product>> GetProductsWithProjection(int categoryIdentifier, bool discontinued)
        {
            var productList = new List<Product>();

            await Task.Run(async () =>
            {

                productList = await Context.Products
                    .Include(product => product.Supplier)
                    .Where(product => product.CategoryId == categoryIdentifier && 
                                             product.Discontinued == discontinued && 
                                             product.UnitsInStock >0)
                    .Select(Product.Projection)
                    .ToListAsync();

            });

            return productList;
        }
        #region permutations for projections

        public static async Task<Orders> GetOrders(int customerIdentifier)
        {
            Orders order = null;

            await Task.Run(async () =>
            {

                order = await Context
                    .Orders
                    .Include(orders => orders.OrderDetails)
                    .Include(orders => orders.CustomerIdentifierNavigation)
                    .FirstOrDefaultAsync(x => x.CustomerIdentifier == customerIdentifier);

            });

            return order;
        }
        /// <summary>
        /// Using extension methods
        /// </summary>
        public static async Task<Orders> GetOrders1(int customerIdentifier)
        {
            Orders order = null;

            await Task.Run(async () =>
            {

                order = await Context.Orders
                    .IncludeDetails()
                    .IncludeCustomer()
                    .FirstOrDefaultAsync(x => x.CustomerIdentifier == customerIdentifier);

            });

            return order;
        }
        public static async Task<Orders> GetOrders2(int customerIdentifier)
        {
            Orders order = null;

            await Task.Run(async () =>
            {

                order = await Context.Orders
                    .IncludeCustomerAndContact()
                    .FirstOrDefaultAsync(
                        ord => ord.CustomerIdentifier == customerIdentifier);
            });

            return order;
        }
        public static async Task<Orders> GetOrders3(int customerIdentifier)
        {
            Orders order = null;

            await Task.Run(async () =>
            {

                order = await Context.Orders
                    .IncludeOptions(contact: true, contactType: true)
                    .FirstOrDefaultAsync();

            });

            return order;
        }

        #endregion
    }
}
