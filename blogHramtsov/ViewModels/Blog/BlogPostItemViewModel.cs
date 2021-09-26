using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.ViewModels.Blog
{
    public class BlogPostItemViewModel
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        [Display(Name = "Автор")]
        public string Author { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        [Display(Name = "Дата")]
        public DateTime Created { get; set; }


        /// <summary>
        /// Заголовок
        /// </summary>
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        /// <summary>
        /// Текст поста
        /// </summary>
        [Display(Name = "Текст поста")]
        public string Data { get; set; }
    }
}
