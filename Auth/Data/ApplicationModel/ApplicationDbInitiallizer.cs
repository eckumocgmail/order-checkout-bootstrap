﻿using ApplicationDb.Entities;

using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ApplicationDb
{
    /// <summary>
    /// Выполняет наполнение базы данных минимальным набором/
    /// </summary>
    public class ApplicationDbInitiallizer 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual List<Role> GetApplicationRoles() {
            return new List<Role>() {
                new Role()
                {
                    Name="Пользователь",
                    Description="Пользователем становится каждый кто зарегистрировал учетную запись",
                    Code="User"
                },
                new Role()
                {
                    Name="Администратор",
                    Description="Администратор выполняет функции редактирования информации на ресурсе",
                    Code="Admin"
                }
            };
        }

        public void DoInitiallize()
        {
            Console.WriteLine("Инициаллизация минимального набора данных");
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                OnInitiallize(db);
                SignoutAll(db);
            }
        }



        /// <summary>
        /// Выход пользователей из системы на уровне данных 
        /// </summary>
        public void SignoutAll(ApplicationDbContext db)
        {

            foreach (var user in (from u in db.Users where u.IsActive == true || u.SecretKey != null select u).ToList())
            {
                user.SecretKey = null;
                user.IsActive = false;
                db.SaveChanges();
            }
        }


        /// <summary>
        /// Метод выполняется после создания контекста данных
        /// </summary>
        /// <param name="db">коонтекст данных </param>
        protected virtual void OnInitiallize(ApplicationDbContext db)
        {
            if (HasRoles(db) == false)
            {         
                InitiallizeRoles(db, GetApplicationRoles());
            }           
            if (HasCalendars(db) == false)
            {
                InitiallizeCalendar(db);
            }
        }
 


        /// <summary>
        /// Проверка наличия данных в таблице Roles
        /// </summary>
        /// <param name="db">контекст данных </param>
        /// <returns></returns>
        private bool HasRoles(ApplicationDbContext db)
        {
            return db.Roles.Count() != 0;
        }


        /// <summary>
        /// Проверка наличия данных в таблице Calendars
        /// </summary>
        /// <param name="db">контекст данных</param>
        /// <returns></returns>
        private bool HasCalendars(ApplicationDbContext db)
        {
            return db.Calendars.Count() != 0;
        }


        /// <summary>
        /// Наполнение таблицы Roles
        /// </summary>
        /// <param name="db">контекст данных</param>
        /// <param name="roles">список ролей в приложении</param>
        private void InitiallizeRoles(ApplicationDbContext db, List<Role> roles)
        {
            foreach(Role role in roles)
            {
                Group group = new Group()
                {
                    Name= role.Name,
                    Description=role.Description
                };
                Person person = new Person() { 
                    FirstName="Константин",
                    SurName="Батов",
                    LastName="Александрович",
                    Tel="7-904-334-1124",
                    Birthday=DateTime.Now
                };
                Account account = new Account() {
                    Email = $"{role.Code}@eckumoc.com",
                    Hash = GetHashSha256("eckumoc@gmail.com"),
                    Activated = DateTime.Now
                };
                Settings settings = new Settings();
                User user = new User(role,person,account, settings);
                UserGroups ug = new UserGroups()
                {
                    User = user,
                    Group = group
                };
                user.UserGroups.Add(ug);
                db.UserGroups.Add(ug);
                db.Settings.Add(settings);
                db.Roles.Add(role);
                db.Groups.Add(group);
                db.Persons.Add(person);
                db.Accounts.Add(account);
                db.Users.Add(user);
            }
            db.SaveChanges();
        }


        /// <summary>
        /// Хэширование текстых данных
        /// </summary>
        /// <param name="text"> текст </param>
        /// <returns> результат хэширования </returns>
        public static string GetHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }



        /// <summary>
        /// Наполнение таблицы Calendars данными на текущий год
        /// </summary>
        /// <param name="db">контекст данных</param>
        private void InitiallizeCalendar(ApplicationDbContext db)
        {        
            int year = DateTime.Now.Year;
            if (db.Calendars.Where(c => c.Year == year).Count() > 360)
            {
                return;
            }

            DateTime p = DateTime.Parse($"01.01.{year}");
            int week = 1;
            while (true)
            {
                
                db.Calendars.Add(new Calendar()
                {
                    Day = p.Day,              
                    Quarter = p.Month < 4 ? 1 : p.Month < 7 ? 2 : p.Month < 10 ? 3 : 4,
                    Month = p.Month,
                    Week = week,
                    Year = p.Year,
                    Timestamp = (long)((new DateTime(p.Year, p.Month, p.Day) - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds)
                });
                if (p.Month == 12 && p.Day == 31)
                {
                    break;
                }
                p = p.AddDays(1);
                db.SaveChanges();

                if (p.DayOfWeek == DayOfWeek.Monday)
                {
                    week++;
                }
            }            
        }
    }
}
