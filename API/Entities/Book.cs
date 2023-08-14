using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }
    }
}