using AutoMapper;
using GreenhouseAPI.Data;
using GreenhouseAPI.Dto.TbBatteries;
using GreenhouseAPI.Dto.TbBatteriess;

namespace GreenhouseAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<TbUserCreateDto, TbUser>().ReverseMap();
            CreateMap<TbUserUpdateDto, TbUser>().ReverseMap();
            CreateMap<TbUserReadOnlyDto, TbUser>().ReverseMap();

            CreateMap<TbBattery, TbBatteriesCreatDto>().ReverseMap();
            CreateMap<TbBattery, TbBatteriesReadOnlyDto>().ReverseMap();
            CreateMap<TbBattery, TbBatteriesUpdateDto>().ReverseMap();


        }
    }
}
