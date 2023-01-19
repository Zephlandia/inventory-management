using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IEquipmentService
   {
      public Task<EquipmentVM> GetEquipmentById(Guid guid);
      public Task<EquipmentVM> AddEquipment(EquipmentCreateVM equipmentCreate);

   }
}
