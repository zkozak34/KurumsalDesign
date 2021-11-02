using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        IResultWithData<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        IResult Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}