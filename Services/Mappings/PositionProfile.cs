using AutoMapper;
using Data.Entities;
using Models.ViewModels;

namespace Services.Mappings
{
   public class PositionProfile : Profile
   {
      public PositionProfile()
      {
         CreateMap<Position, PositionVM>();
         CreateMap<PositionVM, Position>();

         CreateMap<Position, PositionCreateVM>();
         CreateMap<PositionCreateVM, Position>();

         CreateMap<Position, PositionUpdateVM>();
         CreateMap<PositionUpdateVM, Position>();
      }
   }
}
