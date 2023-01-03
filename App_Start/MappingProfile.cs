using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to DTO
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();

            //DTO to domain
            Mapper.CreateMap<CustomerDTO, Customer>();
            Mapper.CreateMap<MovieDTO, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}