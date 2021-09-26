using blogHramtsov.Domain.DB;
using blogHramtsov.Domain.Model;
using blogHramtsov.Security;
using blogHramtsov.ViewModels.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogHramtsov.Controllers
{
    /// <summary>  
    /// Контроллер для работы с блогом
    /// </summary>
    public class BlogController : Controller
    {
        private readonly BlogDbContext _blogDbContext;

        public BlogController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext ?? throw new ArgumentException(nameof(BlogDbContext));
        }


        // <summary>
        // GET: Возвращает страницу блога
        // </summary>
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost(AddNewPostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = this.GetAuthorizedUser();

            var post = new BlogPost
            {
                Created = DateTime.Now,
                Data = model.Data,
                Owner = user.Employee,
                Title = model.Title
            };
            _blogDbContext.BlogPosts.Add(post);
            _blogDbContext.SaveChanges();

            return Redirect("~/Blog");
            ;
        }


        // <summary>
        // GET: Возвращает страницу блога
        // </summary>
        public ActionResult Index()
        {
            var posts = _blogDbContext.BlogPosts
                 .Select(x => new BlogPostItemViewModel
                 {
                     Author = x.Owner.FullName,
                     Created = x.Created,
                     Data = x.Data,
                     Title = x.Title
                 }).OrderByDescending(x => x.Created);

            return View(posts);
        }


        // <summary>
        // GET: Возвращает добавления поста 
        // </summary>
        public IActionResult AddPost()
        {
            return View();
        }
    }
}
