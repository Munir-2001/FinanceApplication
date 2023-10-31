using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinanceApplication.Models
{
    public class EntityDomainViewModel { 
        public transaction t { get; set; }
        public List<entity> entitylist { get; set; }
        public List<domain> domainlist { get; set; }


    }
}
