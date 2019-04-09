using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.Infastracture;
using WebAPI.Model.Models;

namespace WebAPI.Data.Repositorys
{
    public interface IPermissionRepository : IRepository<User>
    {
        List<User> GetByUserId(string userId);
    }

    public class PermissionRepository : RepositoryBase<User>, IPermissionRepository
    {
        public PermissionRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public List<User> GetByUserId(string userId)
        {
            var query = from f in DbContext.Functions
                        join p in DbContext.Permissions on f.ID equals p.FunctionId
                        join r in DbContext.AppRoles on p.RoleId equals r.Id
                        join ur in DbContext.UserRoles on r.Id equals ur.RoleId
                        join u in DbContext.Users on ur.UserId equals u.Id
                        where u.Id == userId
                        select p;
            return query.ToList();
        }
    }
}
