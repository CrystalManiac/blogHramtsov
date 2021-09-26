using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Security
{
    /// <summary>
    /// Константы, используемые в подсистеме безопасности
    /// </summary>
    public class SecurityConstants
    {
        /// <summary>
        /// Администратор
        /// </summary>
        public const string AdminRole = "ADMIN";

        /// <summary>
        /// Пользователь
        /// </summary>
        public const string CustomerRole = "CUSTOMER";

        /// <summary>
        /// Логин администратора
        /// </summary>
        public const string AdminUserName = "ADMIN";

        /// <summary>
        /// Пароль администратора
        /// </summary>
        public const string AdminPassword = "ADMIN";

        /// <summary>
        /// Email администратора
        /// </summary>
        public const string AdminEmail = "admin@test.ru";

        /// <summary>
        /// Email администратора
        /// </summary>
        public const string AdminFirstName = "Супер";

        /// <summary>
        /// Фамилия администатора
        /// </summary>
        public const string AdminSurname = "Пользователь";
    }
}
