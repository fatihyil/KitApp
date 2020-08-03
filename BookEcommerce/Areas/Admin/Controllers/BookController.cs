using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Areas.Admin.Models;
using BookEcommerce.Data.Entities;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly BookService _bookService;
        private readonly CategoryService _categoryService;
        private readonly PublisherService _publisherService;
        private readonly AuthorService _authorService;
        public BookController(BookService bookService, CategoryService categoryService, PublisherService publisherService, AuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var entities = _bookService.GetBooks();
            var model = new List<AdminBookVM>();
            foreach (var item in entities)
            {
                model.Add(new AdminBookVM()
                {
                    Id = item.Id,
                    AuthorId = item.AuthorId,
                    AuthorName = item.Author.FirstName + " " + item.Author.LastName,
                    CategoryId = item.CategoryId,
                    CategoryName = item.Category.Name,
                    Price = item.Price,
                    PublisherId = item.PublisherId,
                    PublisherName = item.Publisher.Name,
                    Title = item.Title
                });
            }
            return View(model);
        }
        public IActionResult Add()
        {
            var categoryEntities = _categoryService.GetCategories();
            var publisherEntities = _publisherService.GetPublishers();
            var authorEntities = _authorService.GetAuthors();
            var model = new AdminBookAddVM();
           

            List<SelectListItem> categoryList = new List<SelectListItem>();
            foreach (var item in categoryEntities)
            {
                categoryList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.CategoryList = categoryList;

            List<SelectListItem> publisherList = new List<SelectListItem>();
            foreach (var item in publisherEntities)
            {
                publisherList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.PublisherList = publisherList;

            List<SelectListItem> authorList = new List<SelectListItem>();
            foreach (var item in authorEntities)
            {
                authorList.Add(new SelectListItem()
                {
                    Text = item.FirstName + " " + item.LastName,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.AuthorList = authorList;
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(AdminBookAddVM model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Book();
                entity.Price = model.Price;
                entity.Title = model.Title;
                entity.StockCount = model.StockCount;
                entity.PublisherId = model.PublisherId;
                entity.AuthorId = model.AuthorId;
                entity.CategoryId = model.CategoryId;
                entity.BookImageUrl = "example.jpg";
                entity.Description = model.Description;
                entity.BookPages = model.BookPages;
                _bookService.Add(entity);
                TempData["IslemBasarılı"] = "Kitap Eklendi !";
                return RedirectToAction("Add");
            }
            else
            {
                TempData["IslemBasarısız"] = "Kitap Eklenmedi !";
                var categoryEntities = _categoryService.GetCategories();
                var publisherEntities = _publisherService.GetPublishers();
                var authorEntities = _authorService.GetAuthors();
                List<SelectListItem> categoryList = new List<SelectListItem>();
                foreach (var item in categoryEntities)
                {
                    categoryList.Add(new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
                ViewBag.CategoryList = categoryList;

                List<SelectListItem> publisherList = new List<SelectListItem>();
                foreach (var item in publisherEntities)
                {
                    publisherList.Add(new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
                ViewBag.PublisherList = publisherList;

                List<SelectListItem> authorList = new List<SelectListItem>();
                foreach (var item in authorEntities)
                {
                    authorList.Add(new SelectListItem()
                    {
                        Text = item.FirstName + " " + item.LastName,
                        Value = item.Id.ToString()
                    });
                }
                ViewBag.AuthorList = authorList;
                return View(model);
            }
        }
        public IActionResult Get(int id)
        {
            var entity = _bookService.GetBookById(id);
            var model = new AdminBookDetailVM();
            model.Id = entity.Id;
            model.Price = entity.Price;
            model.PublisherId = entity.PublisherId;
            model.PublisherName = entity.Publisher.Name;
            model.Title = entity.Title;
            model.Description = entity.Description;
            model.CategoryId = entity.CategoryId;
            model.CategoryName = entity.Category.Name;
            model.AuthorId = entity.AuthorId;
            model.AuthorName = entity.Author.FirstName + " " + entity.Author.LastName;
            model.BookPages = entity.BookPages;
            model.BookImageUrl = entity.BookImageUrl;
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(int id)
        {
            var entity = _bookService.GetBookById(id);
            var model = new AdminBookEditVM();
            model.Id = entity.Id;
            model.Price = entity.Price;
            model.Description = entity.Description;
            model.BookPages = entity.BookPages;
            model.BookName = entity.Title;
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(AdminBookEditVM model)
        {
            var entity = _bookService.GetBookById(model.Id);
            entity.Id = model.Id;
            entity.Price = model.Price;
            entity.Description = model.Description;
            entity.BookPages = model.BookPages;
            var result = _bookService.Edit(entity);
            if (result == 1)
            {
                TempData["IslemBasarili"] = "Kitap güncellenmiştir.";
            }
            else
            {
                TempData["IslemBasarisiz"] = "Kitap güncellenememiştir.";
            }

            return View(model);
        }
    }
}
