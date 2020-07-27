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
    public class OrderController : Controller
    {
        private  UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ShoppingBoxService _shoppingBoxService;
        private readonly OrderService _orderService;
        private readonly OrderDetailService _orderDetailService;
        private readonly BookService _bookService;
        public OrderController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,ShoppingBoxService shoppingBoxService,OrderService orderService,OrderDetailService orderDetailService,BookService bookService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _shoppingBoxService = shoppingBoxService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var UserName = User.Identity.Name;
            if (UserName != null)
            {
                var user = await _userManager.FindByNameAsync(UserName);
                TempData["User"] = user.Id;
            }
            var entities = _shoppingBoxService.GetCards();
            var model = new ShoppingPageVM();
            var modelShoppingCard = new List<ShoppingCardVM>();
            decimal sumPrice = 0;
            foreach (var item in entities)
            {
                modelShoppingCard.Add(new ShoppingCardVM()
                {
                    Id = item.Id,
                    BookId = item.BookId,
                    Price = (int)item.Price,
                    Quantity =item.Quantity,
                    Title =item.Title,
                    UserId = item.UserId
                });
                sumPrice += item.Price *item.Quantity;
            }
            if (modelShoppingCard.Count == 0)
            {
                TempData["EmptyBox"] = "Sepetiniz Boştur !";                
            }
            model.shoppingCards = modelShoppingCard;
            model.SumPrice = sumPrice;
            return View(model);
        }

        public async  Task<IActionResult> Add()
        {
            var UserName = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(UserName);
            var UserId = user.Id;
            var entities = _shoppingBoxService.GetCards();

            Order order = new Order();
            order.AddDate = DateTime.Now;
            order.UserId = UserId;
            order.UserName = UserName;
            _orderService.Add(order);

            decimal totalPrice = 0; 

            foreach (var item in entities)
            {
                OrderDetail detail = new OrderDetail();
                detail.BookId = item.BookId;
                detail.Quantity = item.Quantity;
                detail.OrderId = order.Id;

                _orderDetailService.Add(detail);

                totalPrice = _bookService.GetBookById(item.BookId).Price * item.Quantity + totalPrice;

                _shoppingBoxService.DeleteShopCard(item.Id);
            }

            var model = _orderService.GetById(order.Id);
            model.TotalPrice = totalPrice;

            _orderService.SaveChanges();


            TempData["IslemBasarili"] = "Satın Alma işlemi Başarılı olmuştur.";
            return RedirectToAction("Index");
        }
    }
}
