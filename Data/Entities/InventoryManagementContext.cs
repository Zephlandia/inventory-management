using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
   public class InventoryManagementContext: DbContext
   {

      public InventoryManagementContext(DbContextOptions options) : base(options) { }

      public virtual DbSet<Equipment> Equipment { get; set; }
      public virtual DbSet<Location> Location { get; set; }
      public virtual DbSet<Position> Position { get; set; }
      public virtual DbSet<Type> Type { get; set; }
      public virtual DbSet<User> User { get; set; }


   }
}
