using AutoMapper;
using System;


namespace HarperCollins.WebApplication
{
    public sealed class Mapper
    {
        private static readonly Lazy<IMapper> LazyMapper = new Lazy<IMapper>(() => {
            var config = new MapperConfiguration(cfg =>
            {

               cfg.CreateMap <Service.Models.CustomerData, Models.CustomerData>().ReverseMap();
               cfg.CreateMap <Service.Models.SalesData, Models.SalesData>().ReverseMap();
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
