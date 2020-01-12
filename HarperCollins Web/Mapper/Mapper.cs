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
                cfg.CreateMap<Service.Models.SalesData, Models.SalesData>()
                  .ForMember(dest => dest.CustomerName, target => target.MapFrom(s => s.CustomerData.CustomerName))
                  .ForMember(dest => dest.Format, target => target.MapFrom(s => s.TileData.Format))
                  .ForMember(dest => dest.ListPrice, target => target.MapFrom(s => s.TileData.ListPrice))
                  .ForMember(dest => dest.Author, target => target.MapFrom(s => s.TileData.Author))
                  .ForMember(dest => dest.Title, target => target.MapFrom(s => s.TileData.Title));

                cfg.CreateMap<Models.SalesData, Service.Models.SalesData>()
                   .ForMember(dest => dest.ISBN, target => target.MapFrom(s => s.ISBN))
                   .ForMember(dest => dest.OrderDate, target => target.MapFrom(s => s.OrderDate))
                   .ForMember(dest => dest.OrderQuantity, target => target.MapFrom(s => s.OrderQuantity))
                   .ForMember(dest => dest.OrderStatus, target => target.MapFrom(s => s.OrderStatus))
                   .ForMember(dest => dest.CustomerNumber, target => target.MapFrom(s => s.CustomerNumber));




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
