using Api.ViewModels;
using AutoMapper;

namespace Api.Entities
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CategoryIViewModel, Category>();
            CreateMap<CategoryUViewModel, Category>();
            CreateMap<CategoryDViewModel, Category>();
            CreateMap<CustomerIViewModel, Customer>();
            CreateMap<CustomerUViewModel, Customer>();
            CreateMap<CustomerDViewModel, Customer>();
            CreateMap<DiscountIViewModel, Discount>();
            CreateMap<DiscountUViewModel, Discount>();
            CreateMap<DiscountDViewModel, Discount>();
            CreateMap<SupplierIViewModel, Supplier>();
        }
    }
}
