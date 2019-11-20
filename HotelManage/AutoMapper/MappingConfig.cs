using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManage.AutoMapper
{
    public class MappingConfig
    {
        public MappingConfig()
        {
            CreateMappingFromEntitiesToViewModels();
            CreateMappingFromViewModelsToEntities();

        }

        private void CreateMappingFromViewModelsToEntities()
        {
            //CreateMap<ProductCreateViewModel, Product>();
            //CreateMap<ProductUpdateViewModel, Product>();
            //CreateMap<NewCategoryCreateViewModel, NewCategory>();
            //CreateMap<NewCategoryUpdateViewModel, NewCategory>();
            //CreateMap<NewUpdateViewModel, News>();
            //CreateMap<NewCreateViewModel, News>();
            //CreateMap<SlideCreateViewModel, Slide>();
            //CreateMap<SlideUpdateViewModel, Slide>();
            //CreateMap<CompanyCreateViewModel, Company>();
            //CreateMap<CompanyUpdateViewModel, Company>();
        }

        private void CreateMappingFromEntitiesToViewModels()
        {
            // YOUR code
        }
    }
}