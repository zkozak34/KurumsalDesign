using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            CategoryTest();
        }

        private static void ProductTest()
        {
            var productManager = new ProductManager(new ProductDal());
            Console.WriteLine("------------------- PRODUCTS START -------------------");
            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine($"Ürün Adı: {p.ProductName} \t Kategori: {p.CategoryName}");
            }

            Console.WriteLine("------------------- PRODUCTS END -------------------");
        }
        
        private static void CategoryTest()
        {
            var categoryManager = new CategoryManager(new CategoryDal());
            Console.WriteLine("------------------- CATEGORY START -------------------");
            foreach (var c in categoryManager.GetAll().Data)
            {
                Console.WriteLine(c.CategoryName);
            }

            Console.WriteLine("------------------- CATEGORY END -------------------");
        }
    }
}