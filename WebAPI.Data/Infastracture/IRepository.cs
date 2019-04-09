using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Infastracture
{
    public interface IRepository<T> where T : class
    {
        //Mark an entity new
        void Add(T entity);

        //Mark an entity update
        void Update(T entity);

        //Mark an entity Remove
        void Delete(T entity);

        //Mark an entity Remove
        void DelelteMulti(Expression<Func<T,bool>> where);

        //Get an entity by Id
        T GetSingleById(string Id);

        //Get an entity by Id
        T GetSingleByCondition(Expression<Func<T, bool>> expression,string[] include = null);

        IQueryable<T> GetAll(string[] include = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] include = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total,int index=0,int size=50,string[] include = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> whepredicatere);


    }
}
