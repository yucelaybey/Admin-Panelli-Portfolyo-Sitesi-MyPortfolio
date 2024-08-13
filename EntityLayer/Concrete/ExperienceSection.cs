using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExperienceSection
    {
        public int ExperienceSectionID { get; set; }
        public string? ExperienceName { get; set; }
        public string? ExperienceLocation { get; set; }
        public string? ExperienceTime { get; set; }
        public string? ExperienceDescription { get; set; }
    }
}
