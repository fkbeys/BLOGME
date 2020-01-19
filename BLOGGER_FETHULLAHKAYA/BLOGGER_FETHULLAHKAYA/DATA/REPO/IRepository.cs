using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace BLOGGER_FETHULLAHKAYA.DATA.REPO
{
    // the interface that will help us to implement the add,update ,delete and find methods into the other classes.
    
    public interface IRepository<T> where T : class
    {
        T GetById<TProperty>(TProperty id);

        DbSet<T> Table { get; }

        bool Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        IQueryable<T> All();

        IQueryable<T> Where(Expression<Func<T, bool>> where);

        IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc);

    }
}