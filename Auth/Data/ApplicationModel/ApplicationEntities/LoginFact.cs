﻿using ApplicationDb.Types;

using System.ComponentModel.DataAnnotations;

namespace ApplicationDb.Entities
{
    public class LoginFact: FactsTable
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }


    }
}
