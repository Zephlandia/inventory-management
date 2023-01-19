using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
   public class TypeVM
   {
      public Guid TypeId { get; set; }
      public string Name { get; set; }
   }
}
