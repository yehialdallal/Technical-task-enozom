using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Repository.Entities;
using System.Security.Cryptography.X509Certificates;
using Repository.Dto;

namespace Services.MapperConfiguration
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration() 
        {
            CreateMap<Product,SearchResultDto>().ReverseMap();
            CreateMap<List<Product>,List<SearchResultDto>>().ReverseMap();

        }
    }
}
