using blogHramtsov.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Domain.Model
{
    /// <summary>
    /// Профиль пользователя
    /// </summary>
    public class Employee : Entity
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Адрес пользователя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возвращает полное имя пользователя
        /// </summary>
        public string FullName
        {
            get => FirstName + " " + Surname;
        }
    }
}
