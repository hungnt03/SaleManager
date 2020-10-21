using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Services
{
    public class UnitService:ServiceBase
    {
        public List<KeyValue> GetUnits()
        {
            return _db.Units.Select(x => new KeyValue() { key = x.Id.ToString(), value = x.Name }).ToList();
        }
    }
}
