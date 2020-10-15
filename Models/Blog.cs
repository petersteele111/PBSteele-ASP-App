using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PBsteele.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title{ get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
        public string Post { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
