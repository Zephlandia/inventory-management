using AutoMapper;
using Data.Entities;
using Models.ViewModels;


namespace Services.Mappings
{
   internal class LocationProfile : Profile
   {
      public LocationProfile()
      {
         CreateMap<Location, LocationVM>();
         CreateMap<LocationVM, Location>();

         CreateMap<Location, LocationCreateVM>();
         CreateMap<LocationCreateVM, Location>();

         CreateMap<Location, LocationUpdateVM>();
         CreateMap<LocationUpdateVM, Location>();
      }
   }
}
