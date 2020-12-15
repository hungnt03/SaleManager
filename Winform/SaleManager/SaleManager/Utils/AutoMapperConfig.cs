using AutoMapper;
using SaleManager.Entities;
using SaleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Utils
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductsModel>();
                cfg.CreateMap<Product, ProductModel>();
                cfg.CreateMap<ProductModel, Product>();
                cfg.CreateMap<ConvertProduct, ConvertMasterModel>();
                cfg.CreateMap<ConvertMasterModel, ConvertProduct>();
                cfg.CreateMap<TransactionDetailModel, TransactionDetail>();
                cfg.CreateMap<SupplierModel, Supplier>();
            });
        }
    }
}
