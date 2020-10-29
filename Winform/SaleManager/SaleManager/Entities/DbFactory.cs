using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Entities
{
    public interface IDbFactory : IDisposable
    {
        SaleManagerEntities Init();
    }
    class DbFactory : Disposable, IDbFactory
    {
        private SaleManagerEntities dbContext;

        public SaleManagerEntities Init()
        {
            return dbContext ?? (dbContext = new SaleManagerEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
