using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Infastracture
{
    public class DbFactory : Disposable, IDbFactory
    {
        WebAPIDbcontext dbcontext;
        public WebAPIDbcontext Init()
        {
            return dbcontext ?? (dbcontext = new WebAPIDbcontext());
        }
        protected override void DisposeCore()
        {
            if (dbcontext != null)
                dbcontext.Dispose();
        }
    }
}
