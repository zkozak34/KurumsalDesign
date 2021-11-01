using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductDal: IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (var db = new NorthwindContext())
            {
                return filter == null
                    ? db.Set<Product>().ToList()
                    : db.Set<Product>().Where(filter).ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (var db = new NorthwindContext())
            {
                return db.Set<Product>().SingleOrDefault(filter);
            }
        }

        public void Add(Product item)
        {
            using (var db = new NorthwindContext())
            {
                var productToAdd = db.Entry(item);
                productToAdd.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(Product item)
        {
            using (var db = new NorthwindContext())
            {
                var productToDelete = db.Entry(item);
                productToDelete.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Update(Product item)
        {
            using (var db = new NorthwindContext())
            {
                var productToUpdate = db.Entry(item);
                productToUpdate.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}