using AutoMapper;
using Models.ViewModels;

using Type = Data.Entities.Type;

namespace Services.Mappings
{
   internal class TypeProfile : Profile
   {
      public TypeProfile()
      {
         CreateMap<Type, TypeVM>();
         CreateMap<TypeVM, Type>();

         CreateMap<Type, TypeCreateVM>();
         CreateMap<TypeCreateVM, Type>();

         CreateMap<Type, TypeUpdateVM>();
         CreateMap<TypeUpdateVM, Type>();
      }
   }
}
