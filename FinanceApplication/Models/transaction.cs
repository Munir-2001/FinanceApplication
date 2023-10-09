using Microsoft.EntityFrameworkCore;


namespace FinanceApplication.Models
{
    public class transaction
    {
        public Guid Id { get; set; }
    public string tratype { get; set; }

        public entity entityfortrans { get; set; }

        public domain domainfortrans { get; set; }

        public int amount { get; set; }

        public DateTime dt {  get; set; }


    }
}
