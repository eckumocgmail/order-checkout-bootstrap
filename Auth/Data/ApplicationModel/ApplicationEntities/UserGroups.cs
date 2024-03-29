﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationDb.Entities
{
    public class UserGroups
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int GroupID { get; set; }
        public virtual Group Group { get; set; }

    }
}
