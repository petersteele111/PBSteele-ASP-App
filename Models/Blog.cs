using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PBsteele.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required(ErrorMessage = "You must type in a Title for the Blog")]
        [Column("Title")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "You must enter at least 1 character and do not exceed 100 characters")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Letters and Numbers are allowed for the Post Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You must select a date!")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
        [Required(ErrorMessage = "You must include some data for the post body!")]
        public string Post { get; set; }
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
