using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null
                    ? db.Set<TEntity>().ToList()
                    : db.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                return db.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Add(TEntity item)
        {
            using (var db = new TContext())
            {
                var productToAdd = db.Entry(item);
                productToAdd.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity item)
        {
            using (var db = new TContext())
            {
                var productToDelete = db.Entry(item);
                productToDelete.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Update(TEntity item)
        {
            using (var db = new TContext())
            {
                var productToUpdate = db.Entry(item);
                productToUpdate.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}