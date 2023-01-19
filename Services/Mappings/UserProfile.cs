using AutoMapper;
using Data.Entities;
using Models.ViewModels;


namespace Services.Mappings
{
   public class UserProfile : Profile
   {
      public UserProfile()
      {
         CreateMap<User, UserVM>();
         CreateMap<UserVM, User>();

         CreateMap<User, UserCreateVM>();
         CreateMap<UserCreateVM, User>();

         CreateMap<User, UserUpdateVM>();
         CreateMap<UserUpdateVM, User>();
      }
   }
}
