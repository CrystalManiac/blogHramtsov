using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Domain.Model.Common
{

    /// <summary>
    /// Абстрактный класс сущности
    /// </summary>
    public abstract class Entity
    {

        /// <summary>
        /// Создание экземпляра модели сущности предметной области
        /// </summary>
        protected Entity() { }

        /// <summary>
        /// Id сущности
        /// </summary>
        public virtual long Id { get; set; }

    }
}
