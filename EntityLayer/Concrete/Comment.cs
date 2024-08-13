using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string? CommentPersonName { get; set; }
        public string? CommentPersonMail { get; set; }
        public string? CommentPersonMessage { get; set; }
        public int BlogSectionID { get; set; } // Foreign key
        public BlogSection BlogSection { get; set; }
    }
}
