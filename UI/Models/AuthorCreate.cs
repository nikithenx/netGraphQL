using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class AuthorCreate
    {
        [Required(ErrorMessage = "Please fill a first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please fill a last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please select a gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please select an age")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Please write a short Bio")]
        public string Bio { get; set; }
    }
}