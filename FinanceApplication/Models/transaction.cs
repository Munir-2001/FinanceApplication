namespace FinanceApplication.Models
{
    public class transaction
    {
        private Guid Id { get; set; }
        public string tratype { get; set; }

        private entity entityfortrans { get; set; }

        private domain domainfortrans { get; set; }

        private int amount { get; set; }

        private DateTime dt {  get; set; }


    }
}
