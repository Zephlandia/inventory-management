using AutoMapper;
using Models.ViewModels;

namespace Services.Mappings
{
   internal class TypeProfile : Profile
   {
      public TypeProfile()
      {
         CreateMap<Type, EquipmentTypeVM>();
         CreateMap<EquipmentTypeVM, Type>();

         CreateMap<Type, EquipmentTypeCreateVM>();
         CreateMap<EquipmentTypeCreateVM, Type>();

         CreateMap<Type, EquipmentTypeUpdateVM>();
         CreateMap<EquipmentTypeUpdateVM, Type>();
      }
   }
}
