using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogSection
    {
        public int BlogSectionID { get; set; }
        public string? BlogPicture { get; set; }
        public string? BlogName { get; set; }
        public string? BlogCategory { get; set; }
        public DateTime? BlogTime { get; set; }
        public string? BlogDescription { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
