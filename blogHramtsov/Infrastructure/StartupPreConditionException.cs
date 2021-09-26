﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Infrastructure
{
    /// <summary>
    /// Исключение, вызванное неправилньой средой запуска приложения
    /// Дальнешее выполнение невозможно
    /// </summary>
    public class StartupPreConditionException : Exception
    {
        /// <summary>
        /// Создание экземпляра класса <seealso cref="StartupPreConditionException"/>
        /// </summary>
        /// <param name="message">Сообщение</param>
        public StartupPreConditionException(string message) : base(message)
        {
        }
    }
}