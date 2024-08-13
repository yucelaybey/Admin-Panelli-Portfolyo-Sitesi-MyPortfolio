using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class AddPortfolioSectionViewModel
    {
        public PortfolioSection PortfolioSection { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public string SelectedCategory { get; set; }
    }
}
