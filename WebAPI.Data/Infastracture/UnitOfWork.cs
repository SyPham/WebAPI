using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Infastracture
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private WebAPIDbcontext dbcontext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public WebAPIDbcontext Dbcontext
        {
            get { return dbcontext ?? (dbcontext = dbFactory.Init()); }
        }
        public void Commit()
        {
            dbcontext.SaveChanges();
        }
    }
}
