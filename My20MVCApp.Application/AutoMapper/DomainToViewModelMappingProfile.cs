using AutoMapper;
using My20MVCApp.Application.ViewModels;
using My20MVCApp.Data.Entities;

namespace My20MVCApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
