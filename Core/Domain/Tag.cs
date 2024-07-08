namespace BookCatalogManagementSystemAPI.Core.Domain
{
    public class Tag
    {

        public Guid Id { get; set; }
        public string Name {  get; set; }
        public Guid? BookId { get; set; }
        public Book Book { get; set; }

    }
}
