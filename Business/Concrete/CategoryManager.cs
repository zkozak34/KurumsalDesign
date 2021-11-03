using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        public IResultWithData<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return new SuccessResultWithData<List<Category>>(_categoryDal.GetAll(filter), Messages.MessageToGetAll);
        }

        public IResultWithData<Category> Get(Expression<Func<Category, bool>> filter)
        {
            return new ResultWithData<Category>(_categoryDal.Get(filter), true, Messages.MessageToGetById);

        }

        public IResult Add(Category item)
        {
            _categoryDal.Add(item);
            return new Result(true, Messages.MessageToAdded);

        }

        public IResult Delete(Category item)
        {
            _categoryDal.Delete(item);
            return new Result(true, Messages.MessageToDeleted);

        }

        public IResult Update(Category item)
        {
            _categoryDal.Update(item);
            return new Result(true, Messages.MessageToUpdated);
        }
    }
}