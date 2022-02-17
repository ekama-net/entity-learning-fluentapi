using Microsoft.EntityFrameworkCore;

namespace February16
{
    class MyContext : DbContext
    {
        public DbSet<Delivery> Deliverys { get; set; } = null!; 
        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Shoes> Shoes { get; set; } = null!;
        
        //public MyContext(DbContextOptions<MyContext> options) :base(options)
        //{
        //    //Database.EnsureDeleted();
        //    //Database.EnsureCreated();
        //}

        public MyContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Febr16;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // need to divide like FoodConfiguration ect
        {
            modelBuilder.Entity<Food>().HasKey(f => f.Id); 
            modelBuilder.Entity<Shoes>().HasKey(f => f.Id);
            modelBuilder.Entity<Delivery>().HasKey(f => f.DeliveryId);

            modelBuilder.Entity<Food>() 
                .HasOne(p => p.Delivery)
                .WithMany(d => d.Foods)
                .HasForeignKey(q => q.HasDelivery)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Shoes>()
                .HasOne(p => p.Delivery)
                .WithMany(d => d.Shoes)
                .HasForeignKey(q => q.HasDelivery)
                .OnDelete(DeleteBehavior.SetNull); 

            //configurations
            modelBuilder.Entity<Delivery>().Property(f => f.HasDelivery).HasMaxLength(20).IsRequired();

            modelBuilder.Entity<Food>().Property(f => f.FoodName).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Food>().Property(f => f.FoodCount).HasDefaultValue(1);
            modelBuilder.Entity<Food>().HasCheckConstraint("FoodCount", "FoodCount > 0 AND FoodCount < 100");
            modelBuilder.Entity<Food>().Property(f => f.HasDelivery).HasDefaultValue(2); //not working, because HasDelivery nullable!

            modelBuilder.Entity<Shoes>().Property(f => f.ShoesName).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Shoes>().Property(f => f.ShoesCount).HasDefaultValue(1);
            modelBuilder.Entity<Shoes>().HasCheckConstraint("ShoesCount", "ShoesCount > 0 AND ShoesCount < 100");
            modelBuilder.Entity<Shoes>().Property(f => f.HasDelivery).HasDefaultValue(2); //not working, because HasDelivery nullable!

            //seeding
            modelBuilder.Entity<Food>().HasData(
                new Food { Id = 1, FoodName = "Bread", FoodCount = 2, HasDelivery = 1 },
                new Food { Id = 2, FoodName = "Milk", FoodCount = 2, HasDelivery = 2 },
                new Food { Id = 3, FoodName = "Cucumber" }
                );

            modelBuilder.Entity<Delivery>().HasData(
                new Delivery { DeliveryId = 1, HasDelivery = true },
                new Delivery { DeliveryId = 2, HasDelivery = false }
                );

            modelBuilder.Entity<Shoes>().HasData(
                new Shoes { Id = 1, ShoesName = "Nike", ShoesCount = 1, HasDelivery = 1 },
                new Shoes { Id = 2, ShoesName = "Saucony", ShoesCount = 3, HasDelivery = 1 },
                new Shoes { Id = 3, ShoesName = "Adidas" }
                );
        }

    }
}
