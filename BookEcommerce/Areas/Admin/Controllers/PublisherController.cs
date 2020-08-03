using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Areas.Admin.Models;
using BookEcommerce.Data.Entities;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class PublisherController : Controller
    {
        private readonly PublisherService _publisherService;
        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        public IActionResult Index()
        {
            var entities = _publisherService.GetPublishers();
            if (entities.Count > 0)
            {
                var model = new List<AdminPublisherVM>();
                foreach (var item in entities)
                {
                    model.Add(new AdminPublisherVM()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Address = item.Address
                        
                    });
                }
                return View(model);
            }
            else
            {
                TempData["EmptyPublisher"] = "Yayıncı Bulunmamaktadır !";
                return View();
            }
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AdminPublisherVM model) 
        {
            if (ModelState.IsValid)
            {
                var entity = new Publisher();
                entity.Name = model.Name;
                entity.Address = model.Address;
                _publisherService.Add(entity);
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
    }
}
