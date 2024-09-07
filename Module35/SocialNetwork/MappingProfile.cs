using AutoMapper;
using SocialNetwork.Models;
using SocialNetwork.ViewModels;

namespace SocialNetwork
{
    public class MappingProfile : Profile
    {
       public MappingProfile() 
        {
            CreateMap<RegisterViewModel, User>();
        }
    }
}
