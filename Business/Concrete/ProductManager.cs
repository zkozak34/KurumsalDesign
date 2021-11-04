using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Constants;
using Core.CrossCuttingConcerns.Validation;
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
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorResultWithData<List<Product>>(null, Messages.MaintenanceTime);
            }

            return new SuccessResultWithData<List<Product>>(_productDal.GetAll(), Messages.MessageToGetAll);
        }

        public IResultWithData<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return new ResultWithData<Product>(_productDal.Get(filter), true, Messages.MessageToGetById);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product item)
        {
            // ValidationTool.Validate(new ProductValidator(), item);
            _productDal.Add(item);
            return new Result(true, Messages.MessageToAdded);
        }

        public IResult Delete(Product item)
        {
            _productDal.Delete(item);
            return new Result(true, Messages.MessageToDeleted);
        }

        public IResult Update(Product item)
        {
            _productDal.Update(item);
            return new Result(true, Messages.MessageToUpdated);
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}