using System.ComponentModel.DataAnnotations;

namespace WebApiFirst.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Phone { get; set; } = String.Empty;
        public DateTime Date { get; set; }
    }
}
