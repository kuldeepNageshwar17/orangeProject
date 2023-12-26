using System;
using AutoMapper;
using orange.Services.CouponApi.Models;
using orange.Services.CouponApi.Models.Dto;


namespace Mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;

        }
    }
}

