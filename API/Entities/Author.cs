using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //public virtual ICollection<Book> Books { get; set; }
    }
}