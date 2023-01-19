using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
   public class EquipmentCreateVM
   {
      public string Name { get; set; }
      public string? Description { get; set; }
      public Guid LocationId { get; set; }
      public Guid TypeId { get; set; }
      public bool IsActive { get; set; }
      public string? SerialNumber { get; set; }
      public Guid CreatedBy { get; set; }
   }
}
