using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServiceSection
    {
        public int ServiceSectionID { get; set; }
        public string? ServiceSectionIconUrl { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceDescription { get; set; }
    }
}
