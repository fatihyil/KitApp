using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Data.Entities;
using BookEcommerce.Models;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Controllers
{
    //[Authorize(Roles = "Member")]
    public class BookController : Controller
    {
        private readonly BookService _bookservice;
        private  UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly CategoryService _categoryService;
        private readonly PublisherService _publisherService;
        private readonly AuthorService _authorService;
        public BookController(BookService bookService,UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,CategoryService categoryService,AuthorService authorService,PublisherService publisherService)
        {
            _bookservice = bookService;
            _userManager = userManager;
            _signInManager = signInManager;
            _categoryService = categoryService;
            _authorService = authorService;
            _publisherService = publisherService;
        }

        public async Task<IActionResult> Index()
        {
            var UserName = User.Identity.Name;
            if (UserName != null)
            {
                var user = await _userManager.FindByNameAsync(UserName);
                TempData["User"] = user.Id;
            }
            var categoryEntities = _categoryService.GetCategories();
            var bookentites = _bookservice.GetBooks();
            var authorEntities = _authorService.GetAuthors();
            var publisherentities = _publisherService.GetPublishers();
            var model = new BookCategoryVM();
            var listbook = new List<BooksVM>();
            var listcategory = new List<CategoryVM>();
            var listauthor = new List<AuthorVM>();
            var listpublisher = new List<PublisherVM>();
            foreach (var item in bookentites)
            {
                listbook.Add(new BooksVM() 
                {
                    Id = item.Id,
                    Title = item.Title,
                    BookImgUrl = item.BookImageUrl,
                    CategoryId = item.CategoryId,
                    CategoryName = item.Category.Name,
                    AuthorId = item.AuthorId,
                    AuthorName = $"{item.Author.FirstName }{item.Author.LastName}",
                    PublisherId = item.PublisherId,
                    PublisherName = item.Publisher.Name,
                    Price = item.Price
                });
            }
            model.Books = listbook;
            foreach (var item in categoryEntities)
            {
                listcategory.Add(new CategoryVM()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            model.Categories = listcategory;
            foreach (var item in authorEntities)
            {
                listauthor.Add(new AuthorVM()
                {
                    Id = item.Id,
                    FullName = $"{item.FirstName}{item.LastName}"
                });
            }
            model.Authors = listauthor;
            foreach (var item in publisherentities)
            {
                listpublisher.Add(new PublisherVM() 
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            model.Publishers = listpublisher;
            return View(model);
        }
    }
}
