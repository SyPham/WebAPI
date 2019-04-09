using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Data.Infastracture
{
    public class Disposable : IDisposable
    {
        private bool isDisposable;
        ~Disposable() { Dispose(false); }

        public void Dispose()
        {
            Dispose(true);
            //thu hoi bo nho
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposable && disposing)
            {
                DisposeCore();
            }
            isDisposable = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}
