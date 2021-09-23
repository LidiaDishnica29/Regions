using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RegionsTask.DTO;
using RegionsTask.Models;

namespace RegionsTask.Automapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<RegionDto, Region>().ReverseMap();
        }
    }
}
