using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        IResultWithData<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IResultWithData<T> Get(Expression<Func<T, bool>> filter);
        IResult Add(T item);
        IResult Delete(T item);
        IResult Update(T item);
    }
}