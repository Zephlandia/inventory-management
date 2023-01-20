using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface ITypeService
   {
      public Task<TypeVM?> GetTypeById(Guid guid);
      public Task<TypeVM> AddType(TypeCreateVM equipmentCreate);
      public Task UpdateType(Guid guid, TypeUpdateVM typeUpdateDto);
      public Task DeleteType(Guid guid);
   }
}
