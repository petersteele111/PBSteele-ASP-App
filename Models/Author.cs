using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PBsteele.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "You must type in a name!")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "You must enter as least 1 character and do not exceed 50 characters")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only letters are allowed for the Name!")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 1, ErrorMessage = "You must enter at least 1 character and do not exceed 50 characters")]
        public string Email { get; set; }
        [StringLength(14, MinimumLength = 10, ErrorMessage = "Phone Numbers must be between 10 and 14 characters")]
        public string Phone { get; set; }
    }
}
