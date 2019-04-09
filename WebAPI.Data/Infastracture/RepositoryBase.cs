using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WebAPI.Data.Infastracture
{
    public class RepositoryBase<T> where T : class
    {
        #region Properties
        public WebAPIDbcontext dataContext;
        private readonly IDbSet<T> dbSet;
        protected IDbFactory DbFactory
        {
            get; private set;
        }
        protected WebAPIDbcontext Dbcontext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        #endregion
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = Dbcontext.Set<T>();
        }
        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
            {
                dbSet.Remove(obj);
            }
        }
        #endregion
    }
}
