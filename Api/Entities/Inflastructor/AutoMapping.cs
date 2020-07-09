using Api.ViewModels;
using AutoMapper;

namespace Api.Entities
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
