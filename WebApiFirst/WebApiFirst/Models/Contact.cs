using System.ComponentModel.DataAnnotations;

namespace WebApiFirst.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
    }
}
