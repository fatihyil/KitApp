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
    public class ShoppingController : Controller
    {
        private  UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ShoppingBoxService _shoppingBoxService;
        public ShoppingController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,ShoppingBoxService shoppingBoxService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _shoppingBoxService = shoppingBoxService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddShopCard(ShoppingCardVM shoppingBox)
        {
            var entity = new ShoppingBox();
            entity.BookId = shoppingBox.BookId;
            entity.Price = shoppingBox.Price;
            entity.Quantity = shoppingBox.Quantity;
            entity.UserId = shoppingBox.UserId;
            entity.Title = shoppingBox.Title;
            _shoppingBoxService.Add(entity);
            return Ok();
        }
        public IActionResult DeleteShopCard(int id)
        {
            _shoppingBoxService.DeleteShopCard(id);
            return Ok();

        }
    }
}
