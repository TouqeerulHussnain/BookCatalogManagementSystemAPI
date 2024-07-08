
namespace BookCatalogManagementSystemAPI.Core.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title {  get; set; }
        public string AuthorName { get; set; }
        public DateTime PublicationYear { get; set; }
        public string ISBN { get; set; }
        public string Genre {  get; set; }
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<Chapter>? Chapters { get; set; }
        public int Pages {  get; set; }

    }
}


//builder.Property(b => b.PublicationDate)

//           .HasColumnType("date")

//           .HasAnnotation("MaxLength", 1900)

//           .HasAnnotation("ErrorMessage", "Publication date cannot be more than 1900.");



