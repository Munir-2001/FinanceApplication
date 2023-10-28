using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace FinanceApplication.Models
{
    public class entitymodellists
    {
        public int Id { get; set; }
        public List<SelectListItem> entityview { get; set; }
        public List<SelectListItem> domainview { get; set; }
    }
}
