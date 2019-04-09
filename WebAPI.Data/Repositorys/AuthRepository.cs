using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.Infastracture;
using WebAPI.Model.Models;

namespace WebAPI.Data.Repositorys
{
    public interface IAuthRepository:IRepository<User>
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
    public class AuthRepository : RepositoryBase<User>, IAuthRepository
    {
        protected AuthRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public bool CheckContains(Expression<Func<User, bool>> whepredicatere)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<User, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void DelelteMulti(Expression<Func<User, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll(string[] include = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetMulti(Expression<Func<User, bool>> predicate, string[] include = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetMultiPaging(Expression<Func<User, bool>> filter, out int total, int index = 0, int size = 50, string[] include = null)
        {
            throw new NotImplementedException();
        }

        public User GetSingleByCondition(Expression<Func<User, bool>> expression, string[] include = null)
        {
            throw new NotImplementedException();
        }

        public User GetSingleById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
