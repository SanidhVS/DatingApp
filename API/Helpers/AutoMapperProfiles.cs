using API.DTOs;
using API.Entitities;
using API.Extensions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>() //This is will map the Properties from AppUser to MemberDto
                .ForMember(dest => dest.PhotoUrl, 
                opt => opt.MapFrom( src => src.Photos.FirstOrDefault
                                    (x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(
                    src => src.DateOfBirth.CalculateAge()));  //For removing the getage which returned password details
            CreateMap<Photo, PhotoDto>();//This is will map the Properties from Photo to PhotoDto
        }

    }
}
