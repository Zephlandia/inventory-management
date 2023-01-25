using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Equipment
   {
      [Key]
      public int EquipmentId { get; set; }
      
      [Required]
      [StringLength(100)]
      public string Name { get; set; }
      public string? Description { get; set; }
      
      [ForeignKey("LocationId")]
      public Guid LocationId { get; set; }

      [ForeignKey("ClassificationId")]
      public Guid ClassificationId { get; set; }

      public bool IsActive { get; set; }     
      public string? SerialNumber { get; set; }


      public virtual Classification Classification { get; set; }
      public virtual Location Location { get; set; }

   }
}
