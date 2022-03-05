using Microsoft.EntityFrameworkCore;
using WebMVC_Cake.Models;

namespace WebMVC_Cake.Data
{
    public class CupcakeContext : DbContext
    {
        public CupcakeContext(DbContextOptions<CupcakeContext> options) :base(options){
        }

        public DbSet<Cupcake> Cupcakes { get; set; }
        public DbSet<Bakery> Bakeries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bakery>().HasData(
                new Bakery{BakeryId = 1,BakeryName = "Ekstra wypieki",Address = "Nowa Hata 32-445 ul. Błotna 34",Quantity = 8},
                new Bakery{BakeryId = 2,BakeryName = "Babunia ciastka",Address = "Toruń 62-666 ul. Mogilska 34",Quantity = 4},
                new Bakery{BakeryId = 3,BakeryName = "Ciastka na wynos",Address = "Warszawa 45-444 ul. Błotna 34",Quantity = 3},
                new Bakery{BakeryId = 4,BakeryName = "Dumiecki LTD",Address = "Kraków 31-555 ul. Długa 34",Quantity = 6}
            );
            modelBuilder.Entity<Cupcake>().HasData(
                new Cupcake {
                    CupcakeId = 1,
                    CupcakeType = CupcakeType.Birthday,
                    Description = "Waniliowe pyszne ...",
                    GlutenFree = true,
                    Price = 2.5M,
                    BakeryId = 1,
                    ImageMimeType = "image/jpeg",
                    ImageName = "birthday-cupcake.jpg",
                    CaloricValue = 260
                },
                new Cupcake
                {
                    CupcakeId = 2,
                    CupcakeType = CupcakeType.Chocolate,
                    Description = "Chocolate cupcake with caramel filling and chocolate butter cream",
                    GlutenFree = false,
                    Price = 3.2M,
                    BakeryId = 2,
                    ImageMimeType = "image/jpeg",
                    ImageName = "chocolate-cupcake.jpg",
                    CaloricValue = 195
                },
                new Cupcake
                {
                    CupcakeId = 3,
                    CupcakeType = CupcakeType.Strawberry,
                    Description = "Chocolate cupcake with straberry cream filling",
                    GlutenFree = false,
                    Price = 4,
                    BakeryId = 3,
                    ImageMimeType = "image/jpeg",
                    ImageName = "pink-cupcake.jpg",
                    CaloricValue = 295
                },
                new Cupcake
                {
                    CupcakeId = 4,
                    CupcakeType = CupcakeType.Turqoise,
                    Description = "Vanilla cupcake with butter cream",
                    GlutenFree = true,
                    Price = 1.5M,
                    BakeryId = 4,
                    ImageMimeType = "image/jpeg",
                    ImageName = "turquoise-cupcake.jpg",
                    CaloricValue = 360
                },
                new Cupcake
                {
                    CupcakeId = 5,
                    CupcakeType = CupcakeType.Turqoise,
                    Description = "Przepyszne ciastko",
                    GlutenFree = true,
                    Price = 4.5M,
                    BakeryId = 4,
                    ImageMimeType = "image/jpeg",
                    ImageName = "cupcakes-cover.jpg",
                    CaloricValue = 250
                }

                );
        }
    }
}
