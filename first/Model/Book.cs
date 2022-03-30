using System.ComponentModel.DataAnnotations;

namespace first.Model
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string  name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

    }
}
