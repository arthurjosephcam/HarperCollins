using AutoMapper;
using System;


namespace HarperCollins.WebApplication
{
    internal sealed class Mapper
    {
        private static readonly Lazy<IMapper> LazyMapper = new Lazy<IMapper>(() => {
            var config = new MapperConfiguration(cfg =>
            {

               cfg.CreateMap <Service.Models.CustomerData, Models.CustomerData>().ReverseMap();
               cfg.CreateMap <Service.Models.SalesData, Models.SalesData>()
                 .ForMember(dest => dest.CustomerData, target => target.MapFrom(s => s.CustomerData))
                 .ForMember(dest => dest.TileData, target => target.MapFrom(s => s.TileData))
                 .ReverseMap();
               cfg.CreateMap <Service.Models.TileData, Models.TileData>().ReverseMap();

            });
            return config.CreateMapper();
        });

        public static T Map<T>(Object Source)
        {
           
            return LazyMapper.Value.Map<T>(Source);
        }

        public static TDestination Map<TSource, TDestination>(TSource Source)
        {
            return LazyMapper.Value.Map<TSource, TDestination>(Source);
        }
    }
}
