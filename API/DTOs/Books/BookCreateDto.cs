namespace API.DTOs.Books
{
    public class BookCreateDto
    {
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}