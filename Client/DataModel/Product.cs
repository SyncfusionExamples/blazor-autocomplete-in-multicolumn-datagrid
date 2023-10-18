using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoCompleteInMultiColumn.DataModel
{
    public class Product
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public double? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> ProductsList = new List<Product>
            {
                new Product{ProductID=1, ProductName="Chai", UnitPrice=18.0000, SupplierID=1, UnitsInStock=39, UnitsOnOrder=0 },
                new Product {ProductID=2, ProductName="Chang", UnitPrice=19.000, SupplierID=2, UnitsInStock=17, UnitsOnOrder=49},
                new Product{ ProductID=3, ProductName="Aniseed Syrup", UnitPrice=10.000, SupplierID=1, UnitsInStock=45, UnitsOnOrder=10},
                new Product{ProductID=4, ProductName="Chef Anton's Cajun Seasoning", UnitPrice=16.000, SupplierID=1, UnitsInStock=35, UnitsOnOrder=30},
                new Product{ProductID=5, ProductName="Chef Anton's Gumbo Mix", UnitPrice=86.000, SupplierID=1, UnitsInStock=25, UnitsOnOrder=0},
                new Product{ProductID=6, ProductName="Grandma's Boysenberry Spread", UnitPrice=46.000, SupplierID=1, UnitsInStock=35, UnitsOnOrder=10},
                new Product{ProductID=7, ProductName="Uncle Bob's Organic Dried Pears", UnitPrice=16.000, SupplierID=1, UnitsInStock=15, UnitsOnOrder=18},
                new Product{ProductID=8, ProductName="Mishi Kobe Niku", UnitPrice=26.000, SupplierID=1, UnitsInStock=18, UnitsOnOrder=28},
                new Product{ProductID=9, ProductName="Northwoods Cranberry Sauce", UnitPrice=36.000, SupplierID=1, UnitsInStock=22, UnitsOnOrder=0},
                new Product{ProductID=10, ProductName="Queso Manchego La Pastora", UnitPrice=26.000, SupplierID=1, UnitsInStock=12, UnitsOnOrder=20}
            };
            return ProductsList;
        }
    }
}
