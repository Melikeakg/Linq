﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=1000, UnitsInStock=5 },
                new Product{ ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitsInStock=3 },
                new Product{ ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=6000, UnitsInStock=2 },
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=5000, UnitsInStock=15 },
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB RAM", UnitPrice=8000, UnitsInStock=0 },
            };

            var result = products.Any(p=> p.ProductName =="Acer Laptop");
            Console.WriteLine(result);

            var result2 = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result2.ProductName);

            var result3 =products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result3);

            var result4 =products.Where(p => p.ProductName.Contains("top")).OrderBy(p=> p.UnitPrice);
            foreach (var product in result4)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
