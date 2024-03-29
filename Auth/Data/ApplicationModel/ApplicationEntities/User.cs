﻿using ApplicationDb.Types;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDb.Entities
{
    /// <summary>
    /// Обьект модели пользователя сеансов
    /// </summary>
    public class User: ActiveObject
    {

        public override int GetHashCode()
        {
            return ID;
        }
        public override bool Equals(object obj)
        {
            if(obj is User){
                return ((User)obj).Account.Email==this.Account.Email;
            }else{
                return false;
            }
        }
        public User()
        {            
            UserGroups = new List<UserGroups>();
            Inbox = new List<Message>();
            Outbox = new List<Message>();

        }

        public User(Role role, Person person, Account account, Settings settings)
        {
            UserGroups = new List<UserGroups>();     
            Role = role;
            Person = person;
            Account = account;
            Settings = settings;
            Inbox = new List<Message>();
            Outbox = new List<Message>();
        }

        public int ID { get; set; }


        [DisplayName("Фотография")]
        public int? PhotoID { get; set; }
        public virtual Resource Photo { get; set; }


        [DisplayName("Учетная запись")]
        public int AccountID { get; set; }
        public virtual Account Account { get; set; }


        [DisplayName("Роль")]
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }


        [DisplayName("Настроки")]
        public int SettingsID { get; set; }
        public virtual Settings Settings { get; set; }


        [DisplayName("Персональные данные")]
        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
 
        [NotMapped]
        [DisplayName("Группы")]
        public virtual List<Group> Groups { get; set; }
        public virtual List<UserGroups> UserGroups { get; set; }


        [DisplayName("Кол-во посещений")]
        public int LoginCount { get; set; }

        
        public virtual List<Message> Inbox { get; set; }

        [NotMapped]
        public virtual List<Message> Outbox { get; set; }

    }

}
