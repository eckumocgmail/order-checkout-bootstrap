﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApplicationDb.Entities
{
    /// <summary>
    /// Ученая запись пользователя
    /// </summary>
    public class Account
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Электронный адрес")]
        [DataType(
            DataType.EmailAddress,
            ErrorMessage = "Электронный адрес задан некорректно"
        )]

        [NotNull]
        [Required(ErrorMessage = "Не указан электронный адрес")]
        public string Email { get; set; }


        [AllowNull]      
        [DataType(DataType.Date)]
        public DateTime? Activated { get; set; }

        
        public string ActivationKey { get; set; }

        [NotNull]
        public string Hash { get; set; }


        public string RFID { get; set; }

    }
}
