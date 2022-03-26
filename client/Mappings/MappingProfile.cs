using _300490950_morden__Project.DTOs;
using AutoMapper;
using ShippingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _300490950_morden__Project.Mappings
{
    public class MappingProfile :  Profile
    {
        public MappingProfile()
        {
            CreateMap<ProvinceCode, ProvinceCodeDTO>();
            CreateMap<ProvinceCodesCreateDTO, ProvinceCode>();
            CreateMap<ProvinceCodesDeleteDTO, ProvinceCodeDTO>();
            CreateMap<ProvinceCodesUpdateDTO, ProvinceCode>();


        }
    }
}
