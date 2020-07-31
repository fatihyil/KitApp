using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Areas.Admin.Models;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _authorService;
        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }
        /// <summary>
        /// Author listeleme Action
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var entities = _authorService.GetAuthors();
            var model = new List<AdminAuthorVM>();

            foreach (var item in entities)
            {
                model.Add(new AdminAuthorVM()
                {
                    Id = item.Id,
                    FullName = $"{item.FirstName} {item.LastName}"
                });
            }
            return View(model);
        }
    }
}
