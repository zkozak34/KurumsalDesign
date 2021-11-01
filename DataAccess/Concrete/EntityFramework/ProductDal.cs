using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductDal: EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (var db = new NorthwindContext())
            {
                var result =
                    from p in db.Products
                    join c in db.Categories on p.CategoryId equals c.CategoryId
                    select new ProductDetailsDto
                    {
                        ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName,
                        UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock
                    };

                return result.ToList();
            }
        }
    }
}