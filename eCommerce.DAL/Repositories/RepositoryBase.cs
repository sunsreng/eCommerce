﻿using eCommerce.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce.DAL.Repositories
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        internal DataContext context;
        internal DbSet<TEntity> dbSet;
        public RepositoryBase(DataContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        public virtual TEntity GetById(object id)
        {
            return dbSet.Find(id);
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }
        public virtual IQueryable<TEntity> GetAll(object filter)
        {
            return null;
        }
        public virtual IQueryable<TEntity> GetFullObject(object id)
        {
            return null;
        }
        public IQueryable<TEntity> GetPaged(int top =20, int skip =0, object orderBy = null, object filter = null)
        {
            return null;
        }
        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
        public virtual void Delete(object id)
        {
            TEntity entity = dbSet.Find(id);
            Delete(entity);
        }
        public virtual void Commit()
        {
            context.SaveChanges();
        }
        public virtual void Dispose()
        {
            context.Dispose();
        }
    }
}
