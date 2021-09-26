using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.ViewModels.Blog
{
    public class AddNewPostViewModel
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        [Required]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        /// <summary>
        /// Текст поста
        /// </summary>
        [Required]
        [Display(Name = "Текст поста")]
        public string Data { get; set; }
    }
}
