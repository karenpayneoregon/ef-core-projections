using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLoggingExample.Contexts;
using ConsoleLoggingExample.Models;
using ConsoleLoggingExample.Projections;
using Microsoft.EntityFrameworkCore;

namespace ConsoleLoggingExample.Classes
{
    public class Operations
    {
        public static NorthWindContext Context { get; } = new NorthWindContext();

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
    }
}
