using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Position
   {
      [Key]
      public Guid PositionId { get; set; }

      [Required]
      [StringLength(100)]
      public string Name { get; set; }
   }
}
