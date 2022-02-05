using Microsoft.EntityFrameworkCore;
using WebApiFirst.Models;

namespace WebApiFirst.Data
{
    public class ContactDbContext :DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) :base(options){  }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Date = new DateTime(2021, 9, 12),
                    Phone = "122323232"
                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Monika",
                    LastName = "Małecka",
                    Date = new DateTime(2021, 3, 22),
                    Phone = "4433333"
                },
                new Contact
                {
                    Id = 3,
                    FirstName = "Teresa",
                    LastName = "Tur",
                    Date = new DateTime(2020, 12, 12),
                    Phone = "555533333"
                },
                new Contact
                {
                    Id = 4,
                    FirstName = "Tomasz",
                    LastName = "Bomasz",
                    Date = new DateTime(2020, 5, 21),
                    Phone = "467777777"
                }

            );
        }
    }
}
