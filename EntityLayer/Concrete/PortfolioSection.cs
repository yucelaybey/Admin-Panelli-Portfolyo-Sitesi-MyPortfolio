using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PortfolioSection
    {
        public int PortfolioSectionID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ProjectPicture { get; set; }
        public string? CategoryName { get; set; }
    }

}
