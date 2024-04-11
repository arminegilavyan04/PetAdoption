using Microsoft.EntityFrameworkCore;
using PetAdoptionProject.Components.Pages;
using PetAdoptionProject.Models;

namespace PetAdoptionProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> DefaultConnection) : base(DefaultConnection)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ClientDB>().HasKey(c => c.ClientID);
            // Other configurations
            modelBuilder.Entity<ClientDB>().HasData(
                    new ClientDB { ClientID = 1, FirstName = "Ani", LastName = "Gilavyan", PetType = "dog", Email = "anigilavyan@gmail.com", Password = "anianiani", ClientAddress = "Goris", PhoneNumber = "2255526852", AnimalID = 84 },
                    new ClientDB { ClientID = 2, FirstName = "Artyom", LastName = "Gilavyan", PetType = "pig", Email = "manushatasunts@gmail.com", Password = "mamamama", ClientAddress = "Goris", PhoneNumber = "852565", AnimalID = 42 }
                    );

            modelBuilder.Entity<UserDB>().HasKey(u => u.UserID);
            // Other configurations
            modelBuilder.Entity<UserDB>().HasData(
                    new UserDB { UserID = 1, FirstName = "Manush", LastName = "Atasunts", PetType = "cat", PetName = "Lola", Email = "arminegilavyan04@gmail.com", Password = "Aniartyom", UserAddress = "Goris", PhoneNumber = "642574", AnimalID = 12 },
                    new UserDB { UserID = 2, FirstName = "Arkadi", LastName = "Gilavyan", PetType = "dog", PetName = "Boghar", Email = "arminegilavya125n04@gmail.com", Password = "lalala", UserAddress = "Goris", PhoneNumber = "7547854", AnimalID = 31 }
                    );

            modelBuilder.Entity<PetsDB>().HasKey(p => p.PetID);
            // Other configurations
            modelBuilder.Entity<PetsDB>().HasData(
                    new PetsDB { PetID = 1, PetName = "Rony", PetDescription = "Healthy", PetType = "Dog" },
                    new PetsDB { PetID = 2, PetName = "Boghar", PetDescription = "Healthy", PetType = "Dog" },
                    new PetsDB { PetID = 3, PetName = "August", PetDescription = "Needs medical care", PetType = "Dog" }
                    );
            modelBuilder.Entity<NourishmentDB>().HasKey(n => n.NourishID);
            // Other configurations
            modelBuilder.Entity<NourishmentDB>().HasData(
                    new NourishmentDB { NourishID = 1, Brand = "DogNour", NourishName = "MommyDoggy", Price = 100 },
                    new NourishmentDB { NourishID = 2, Brand = "YumDog", NourishName = "DogSnack", Price = 200 },
                    new NourishmentDB { NourishID = 3, Brand = "PetYummas", NourishName = "Yummy", Price = 300 }
                    );
        }
        public DbSet<ClientDB> Clients { get; set; }
        public DbSet<UserDB> Users { get; set; }
        public DbSet<PetsDB> Pets { get; set; }
        public DbSet<NourishmentDB> Nourishments { get; set; }
    }
}
