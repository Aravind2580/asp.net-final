namespace Assignment002
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        [Required]
        public string ISBN { get; set; }

        public bool Available { get; set; }

        // Foreign key
        public string UserId { get; set; }
        // Navigation property
        public User User { get; set; }
    }

}
