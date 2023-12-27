using AutoMapper;
using DockerWebApi.Dtos;
using DockerWebApi.Models;

namespace DockerWebApi.Profiles
{
    public class PlatformProfile: Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
