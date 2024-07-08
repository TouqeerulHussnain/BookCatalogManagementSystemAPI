namespace BookCatalogManagementSystemAPI.Core.Domain
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public string Title {  get; set; }
        public int PageCount {  get; set; }

        public Guid? BookIdFK;
        public Book Book {  get; set; } 

    }
}
