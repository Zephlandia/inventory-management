using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class User
   {
      [Key]
      public Guid UserId { get; set; }
      [StringLength(20)]
      public string? PhoneNumber { get; set; }
      [Required]
      [StringLength(50)]
      public string Email { get; set; }
      public bool IsActive { get; set; }
      [Required]
      [StringLength(50)]
      public string FirstName { get; set; }
      [Required]
      [StringLength(50)]
      public string Lastname { get; set; }      
   }
}
