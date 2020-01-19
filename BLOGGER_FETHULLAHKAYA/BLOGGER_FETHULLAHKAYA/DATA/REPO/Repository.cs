using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BLOGGER_FETHULLAHKAYA.DATA.REPO
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // the Repository is interfaced from IRepostory class and with the T implementation, it will get the model dynamic.
       // the method names are choosed as their purpose.
            
        private readonly DatabaseContext dbContext;

        public DbSet<T> Table { get; set; }

        DbSet<T> IRepository<T>.Table => throw new NotImplementedException();

        //singleton in constructor.
        //singleton prenciple ( it gets instance when the app run first time. and it will use it for each transaction.
        public Repository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
            Table = dbContext.Set<T>();
        }


        public bool Add(T entity)
        {
            Table.Add(entity);
            return Save();
        }

        public bool Update(T entity)
        {
      
            Table.Update(entity);
            return Save();
             
        }
        public bool Delete(T entity)
        {
            Table.Remove(entity);
            return Save();
        }
        public IQueryable<T> All()
        {
            return Table;
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> where)
        {
            return Table.Where(where);
        }


        public IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            if (isDesc)
                return Table.OrderByDescending(orderBy);
            return Table.OrderBy(orderBy);
        }
        private bool Save()
        {
            try
            {
                dbContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public T GetById<TProperty>(TProperty id)
        {
            return Table.Find(id);
        }
    }
}
