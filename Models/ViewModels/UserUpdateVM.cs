using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
   public  class UserUpdateVM
   {
      public string? PhoneNumber { get; set; }
      public string Email { get; set; }
      public bool IsActive { get; set; }
      public string FirstName { get; set; }
      public string Lastname { get; set; }
   }
}
