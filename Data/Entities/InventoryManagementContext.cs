using Microsoft.EntityFrameworkCore;


namespace Data.Entities
{
   public class InventoryManagementContext: DbContext
   {

      public InventoryManagementContext(DbContextOptions options) : base(options) { }

      public virtual DbSet<Equipment> Equipment { get; set; }
      public virtual DbSet<Location> Location { get; set; }
      public virtual DbSet<Position> Position { get; set; }
      public virtual DbSet<Classification> Classification{ get; set; }
      public virtual DbSet<User> User { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
   

      }

   }
}
