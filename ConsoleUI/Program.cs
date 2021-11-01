using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = new ProductManager(new ProductDal());
            Console.WriteLine("------------------- PRODUCTS START -------------------");
            foreach (var p in productManager.GetAll()) 
            {
                Console.WriteLine(p.ProductName);
            } 
            Console.WriteLine("------------------- PRODUCTS END -------------------");
            
            var categoryManager = new CategoryManager(new CategoryDal());
            Console.WriteLine("------------------- CATEGORY START -------------------");
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.WriteLine("------------------- CATEGORY END -------------------");
        }
    }
}