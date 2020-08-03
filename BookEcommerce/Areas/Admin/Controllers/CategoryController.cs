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
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var entites = _categoryService.GetCategories();
            if (entites.Count > 0)
            {
                var model = new List<AdminCategoryVM>();
                foreach (var item in entites)
                {
                    model.Add(new AdminCategoryVM()
                    {
                        Id = item.Id,
                        Name = item.Name
                    });
                }
                return View(model);
            }
            else
            {
                TempData["EmptyCategory"] = "Kategori Bulunmamaktadır !";
                return View();
            }
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AdminCategoryVM model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category();
                entity.Name = model.Name;
                _categoryService.Add(entity);
                return View(model);
            }
            else
            {
                return View(model);
            }
        }
    }

}
