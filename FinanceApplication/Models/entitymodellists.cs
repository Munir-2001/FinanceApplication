using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace FinanceApplication.Models
{
    public class entitymodellists
    {
        public int Id { get; set; }
        public List<entity> entityview { get; set; }
        public List<domain> domainview { get; set; }
    }
}
