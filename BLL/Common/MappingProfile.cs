using AutoMapper;
using BLL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agent, UserDTO>();
            CreateMap<UserDTO, Agent>();
            CreateMap<UserDTO, Customer>();
            CreateMap<Customer, UserDTO>();

        }
    }
}
