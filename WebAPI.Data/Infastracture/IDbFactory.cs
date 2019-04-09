using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Infastracture
{
   public interface IDbFactory:IDisposable
    {
        WebAPIDbcontext Init(); 
    }
}
