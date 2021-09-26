using blogHramtsov.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Domain.Model
{

    /// <summary>
    /// Пост(блог)
    /// </summary>
    public class BlogPost : Entity
    {

        /// <summary>
        /// Создатель поста
        /// </summary>
        public Employee Owner { get; set; }

        /// <summary>
        /// Дата создания поста
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Заголовок поста
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Тело поста
        /// </summary>
        public string Data { get; set; }
    }
}
