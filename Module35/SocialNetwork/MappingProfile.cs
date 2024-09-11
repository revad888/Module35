﻿using AutoMapper;
using SocialNetwork.Models;
using SocialNetwork.ViewModels;

namespace SocialNetwork
{
    public class MappingProfile : Profile
    {
       public MappingProfile() 
        {
            CreateMap<RegisterViewModel, User>().ForMember(x => x.BirthDate, opt => opt.MapFrom(c => new DateTime((int)c.Year, (int)c.Month, (int)c.Date)))
    .ForMember(x => x.Email, opt => opt.MapFrom(c => c.EmailReg))
    .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.Login));
        }
    }
}
