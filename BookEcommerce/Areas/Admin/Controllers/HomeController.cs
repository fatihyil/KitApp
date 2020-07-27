using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Areas.Admin.Models;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly BookService _bookservice;
        private readonly AuthorService _authorService;
        private readonly PublisherService _publisherService;
        private readonly OrderService _orderService;
        public HomeController(BookService bookService,AuthorService authorService,PublisherService publisherService,OrderService orderService)
        {
            _bookservice = bookService;
            _authorService = authorService;
            _publisherService = publisherService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var bookcount =  _bookservice.GetBooks().Count;
            var authorcount = _authorService.GetAuthors().Count;
            var publishercount = _publisherService.GetPublishers().Count;
            var ordercount = _orderService.GetOrders().Count;

            var model = new MainPageVM() 
            {
                BookCount = bookcount,
                AuthorCount = authorcount,
                OrderCount = ordercount,
                PublisherCount = publishercount
            };
            return View(model);
        }
    }
}
