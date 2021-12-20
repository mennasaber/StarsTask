using AutoMapper;
using FirstTask.Models;
using FirstTask.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTask
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Tip, TipDto>();
            CreateMap<TipDto, Tip>();
        }
    }
}
