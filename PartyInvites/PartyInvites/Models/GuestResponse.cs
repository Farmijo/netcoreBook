using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please, enter a value!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, enter a value!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please, enter a value!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please, enter a value!")]
        public bool? WillAttend { get; set; }
        
    }
}
