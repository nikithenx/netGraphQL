namespace API.DTOs.Authors
{
    public class AuthorUpdateDto
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}