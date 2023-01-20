using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface ILocationService
   {
      public Task<LocationVM> GetLocationById(Guid guid);
      public Task<LocationVM> AddLocation(LocationCreateVM LocationCreate);

   }
}
