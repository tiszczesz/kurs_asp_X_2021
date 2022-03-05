using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC_Cake.Models
{
    public class Cupcake
    {
        [Key] 
        public int CupcakeId { get; set; }

        [Required(ErrorMessage = "Wybierz rodzaj ciastka")]
        [Display(Name = "Rodzaj ciastak")]
        public CupcakeType? CupcakeType { get; set; }

        [Required(ErrorMessage = "Wprowadź opis ciastka")]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Bezglutenowe")] 
        public bool GlutenFree { get; set; }

        [Display(Name = "Ilość kalorii")] 
        public int CaloricValue { get; set; }

        [Range(1,15)]
        [Required(ErrorMessage = "Podaj cenę")]
        [Display(Name = "Cena")]
        public decimal? Price { get; set; }

        [Display(Name="Obrazek")]
        [NotMapped]
        public IFormFile PhotoAvatar { get; set; }

        public string ImageName { get; set; }

        public byte[]? PhotoFile { get; set; }

        public string ImageMimeType { get; set; }

        [Required(ErrorMessage = "Wybierz cukiernie")]
        [Display(Name = "Wybierz cukiernie")]
        public int? BakeryId { get; set; }

        [Required(ErrorMessage = "Wybierz cukiernie")]
        public virtual Bakery Bakery { get; set; }
    }
}
