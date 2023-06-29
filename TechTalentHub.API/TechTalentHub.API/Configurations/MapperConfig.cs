using AutoMapper;
using TechTalentHub.API.Data;
using TechTalentHub.API.Models.TechTalentHubUser;

namespace TechTalentHub.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<TechTalentHubUser, TechTalentHubUserDTO>().ReverseMap();
        }
    }
}
