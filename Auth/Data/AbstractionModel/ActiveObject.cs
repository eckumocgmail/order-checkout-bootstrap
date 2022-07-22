using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ApplicationDb.Types
{
    /// <summary>
    /// Абстрактный класс активных обьектов приложения( пользователи, службы ).
    /// Активные обьекты проходят процедуру авторизации в приложении.
    /// </summary>
    public abstract class ActiveObject
    {

        [DisplayName("Последнее посещение")]        
        public long LastActive { get; set; }


        [DisplayName("Онлайн")]
        public bool IsActive { get; set; }


        [DisplayName("Секретный ключ")]
        public string SecretKey { get; set; }



      
    }
}
