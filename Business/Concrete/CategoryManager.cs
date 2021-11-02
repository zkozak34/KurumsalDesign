using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
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
            return new SuccessResultWithData<List<Category>>(_categoryDal.GetAll(filter), "Kategoriler listelendi.");
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);

        }

        public IResult Add(Category item)
        {
            _categoryDal.Add(item);
            return new Result(true, "Başarılı");

        }

        public void Delete(Category item)
        {
            _categoryDal.Delete(item);

        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);

        }
    }
}