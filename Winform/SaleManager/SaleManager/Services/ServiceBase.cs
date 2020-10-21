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
        public ServiceBase()
        {
            _db = new SaleManagerEntities();
        }
    }
}
