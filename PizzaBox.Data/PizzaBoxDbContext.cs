using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain;

namespace PizzaBox.Data
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> Crust { get; set; }
    public DbSet<History> History { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Size> Size { get; set; }
    public DbSet<Store> Store { get; set; }
    public DbSet<Topping> Topping { get; set; }
    public DbSet<ToppingsOrder> ToppingsOrder { get; set; }
    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;initial catalog=PizzaBoxDb;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(c => c.CrustId);
      builder.Entity<Crust>().HasIndex(c => c.CrustName).IsUnique();
      builder.Entity<History>().HasKey(c => c.HistoryId);
      builder.Entity<Location>().HasKey(c => c.LocationId);
      builder.Entity<Location>().HasIndex(c => c.LocationName).IsUnique();
      builder.Entity<Order>().HasKey(c => c.OrderId);      
      builder.Entity<Pizza>().HasKey(c => c.PizzaId);      
      builder.Entity<Size>().HasKey(c => c.SizeId);
      builder.Entity<Size>().HasIndex(c => c.SizeName).IsUnique();
      builder.Entity<Store>().HasKey(c => c.StoreId);      
      builder.Entity<Topping>().HasKey(c => c.ToppingId);
      builder.Entity<Topping>().HasIndex(c => c.ToppingsName).IsUnique();
      builder.Entity<ToppingsOrder>().HasKey(c => c.ToppingsOrderId);      
      builder.Entity<User>().HasKey(c => c.UserId);
      builder.Entity<User>().HasIndex(c => c.Username).IsUnique();
      
    }
  }
}
