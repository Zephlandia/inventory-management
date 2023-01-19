using AutoMapper;
using Data.Entities;
using Models.ViewModels;

namespace Services.Mappings
{
   public class EquipmentProfile: Profile
   {
      public EquipmentProfile()
      {
         CreateMap<Equipment, EquipmentVM>();
         CreateMap<EquipmentVM, Equipment>();

         CreateMap<Equipment, EquipmentCreateVM>();
         CreateMap<EquipmentCreateVM, Equipment>();

         CreateMap<Equipment, EquipmentUpdateVM>();
         CreateMap<EquipmentUpdateVM, Equipment>();
      }
   }
}
