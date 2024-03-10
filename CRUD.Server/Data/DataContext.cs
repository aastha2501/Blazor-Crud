using CRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Category>().HasData(
                  new Category{ Id = "55b7a860-9f40-47c4-9cbb-f72b808921c8", Name = "Fiction" },
            new Category { Id = "44db7a33-d170-4c47-bcdc-adb8f1f7c834", Name = "Ethical" });
            modelBuilder.Entity<Book>().HasData(
                 new Book { Id = Guid.NewGuid(), Title = "The Secret of the Nagas", Description = "The Secret of the Nagas is the second book of Amish Tripathi, second book of Amishverse, and also the second book of Shiva Trilogy. The story takes place in the imaginary land of Meluha and narrates how the inhabitants of that land are saved from their wars by a nomad named Shiva. It begins from where its predecessor, The Immortals of Meluha, left off, with Shiva trying to save Sati from the invading Naga. Later Shiva takes his troop of soldiers and travels far east to the land of Branga, where he wishes to find a clue to reach the Naga people. Shiva also learns that Sati's first child is still alive, as well as her twin sister. His journey ultimately leads him to the Naga capital of Panchavati, where he finds a surprise waiting for him.", Author = "Amish Tripathy", CategoryId = "55b7a860-9f40-47c4-9cbb-f72b808921c8"},
                 new Book { Id = Guid.NewGuid(), Title = "Sita the Warrior", Description = "During a trip Janak, the king of Mithila and his wife Sunaina find a child on the road, being protected by a vulture. They adopt the child and name her Sita, for she was found in a furrow. As an adolescent, Sita is sent to the ashram of Rishi Shvetaketu for her studies. There she learns about martial arts and gains knowledge on different subjects. She also makes friendship with a girl Radhika, and her cousin Hanuman, who was a Vayuputra—the tribe left by the previous Mahadev, Lord Rudra. He is also a Naga whose appearance looks like the head of a monkey placed on a human body.", Author = "Amish Tripathy", CategoryId = "55b7a860-9f40-47c4-9cbb-f72b808921c8" }
                );
        }

        public DbSet<Book> Books { get; set; }   
        public DbSet<Category> Categories { get; set; }
    }
}
