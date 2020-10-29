using SaleManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class ServiceBase
    {
        public SaleManagerEntities _db;
        public IUnitOfWork _unitOfWork;
        public ServiceBase()
        {
            _db = new SaleManagerEntities();
            //this._unitOfWork = new UnitOfWork(_db.);
        }
    }
}
