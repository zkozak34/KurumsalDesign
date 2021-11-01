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
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            }
        }
    }
}