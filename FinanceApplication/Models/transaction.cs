﻿using Microsoft.EntityFrameworkCore;


namespace FinanceApplication.Models
{
    public class transaction
    {
        public Guid Id { get; set; }
        public string tratype { get; set; }//debit or credit

        public string ent {get;set;}

        public string dom { get; set; }
        //store guid of the entity and dom
       // public entitymodellists entitymodellists { get; set; }

        public int amount { get; set; }
        public DateTime dt {  get; set; }


    }
}
