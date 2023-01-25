using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class Location
   {
      [Key]
      public Guid LocationId { get; set; }

      [Required]
      [StringLength(50)]
      public string Name { get; set; }

      [StringLength(50)]
      public string? Address1 { get; set; }

      [StringLength(50)]
      public string? Address2 { get; set; }

      [StringLength(50)]
      public string? City { get; set; }

      [StringLength(30)]
      public string? Country { get; set; }
      public string? Description { get; set; }
      public bool IsActive { get; set; }

      [ForeignKey("UserId")]
      public Guid ManagerUserId { get; set; }

      public string? PostalCode { get; set; }
      [StringLength(26)]
      public string? Province { get; set; }

      public virtual User User { get; set; }
   }
}
