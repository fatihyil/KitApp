using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookEcommerce.Models;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using BookEcommerce.Data.Entities;

namespace BookEcommerce.Controllers
{
    //[Area("Member")]
    //[Authorize(Roles = "Member")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookService _bookService;
        private  UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(ILogger<HomeController> logger,BookService bookService,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _bookService = bookService;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {           
            var entities = _bookService.GetBooks();
            var model = new List<BooksVM>();
            foreach (var item in entities)
            {
                model.Add(new BooksVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                    BookImgUrl = item.BookImageUrl,
                    AuthorName = item.Author.FirstName + " "+ item.Author.LastName,
                    AuthorId = item.AuthorId,
                    CategoryId = item.CategoryId,
                    CategoryName = item.Category.Name,
                    PublisherId = item.PublisherId,
                    PublisherName = item.Publisher.Name,
                    Price = item.Price
                });
            }
            return View(model);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var UserName = User.Identity.Name;
            if (UserName != null)
            {
                var user = await _userManager.FindByNameAsync(UserName);
                TempData["User"] = user.Id;
            }           

            var entity = _bookService.GetBookById(id);
            var categoryID = entity.CategoryId;
            var entites = _bookService.GetBooksByCategoryId(categoryID);
            var model = new BookRelatedDetailVM();
            model.Id = entity.Id;
            model.Title = entity.Title;
            model.Description = entity.Description;
            model.BookImgUrl = entity.BookImageUrl;
            model.BookPages = entity.BookPages;
            model.Price = entity.Price;
            model.CategoryName = entity.Category.Name;
            model.PublisherName = entity.Publisher.Name;
            model.AuthorName = entity.Author.FirstName +" "+entity.Author.LastName;
            var reletedbooks = new List<ReletedBooksVM>();
            foreach (var item in entites)
            {
                reletedbooks.Add(new ReletedBooksVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                    BookImgUrl = item.BookImageUrl
                });
                
            }
            model.books = reletedbooks;
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
