using AutoMapper;
using HandsOnAPIUsingAutoMapper.DTOs;
using HandsOnAPIUsingAutoMapper.Entities;

namespace HandsOnAPIUsingAutoMapper.Profiles
{
    public class DriverProfile:Profile
    {
        public DriverProfile()
        {
            CreateMap<DriverDto, Driver>(); //mapping DriverDto and Drive entity
            CreateMap<Driver, DriverDto>(); //mapping Driver to DriverDto
        }
    }
}
