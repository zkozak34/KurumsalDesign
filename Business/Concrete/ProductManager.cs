using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        public IResultWithData<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new SuccessResultWithData<List<Product>>(_productDal.GetAll(filter), "Ürünler listelendi.");
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        public IResult Add(Product item)
        {
            _productDal.Add(item);
            return new SuccessResult(Messages.ProductAdded);
        }

        public void Delete(Product item)
        {
            _productDal.Delete(item);
        }

        public void Update(Product item)
        {
            _productDal.Update(item);
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}