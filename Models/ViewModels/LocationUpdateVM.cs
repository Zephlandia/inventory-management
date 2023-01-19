using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
   public class LocationUpdateVM
   {
      public string Name { get; set; }
      public string? Address1 { get; set; }
      public string? Address2 { get; set; }
      public string? City { get; set; }
      public string? Country { get; set; }
      public string? Description { get; set; }
      public bool IsActive { get; set; }
      public Guid ManagerUserId { get; set; }
      public string? PostalCode { get; set; }
      public string? Province { get; set; }
   }
}
