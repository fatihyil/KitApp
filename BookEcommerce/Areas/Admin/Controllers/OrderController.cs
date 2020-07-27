using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookEcommerce.Areas.Admin.Models;
using BookEcommerce.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookEcommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        private readonly OrderDetailService _orderDetailService;
        private UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public OrderController(OrderService orderService,OrderDetailService orderDetailService, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var orders = _orderService.GetOrders();
            var model = new List<AdminOrdersVM>();
            foreach (var item in orders)
            {
                var orderDetails = _orderDetailService.GetOrderDetailsByOrderId(item.Id);
                var OrderDetailListVM = new List<AdminOrderDetailVM>();
                foreach (var detail in orderDetails)
                {
                    OrderDetailListVM.Add(new AdminOrderDetailVM()
                    {
                        Id = detail.Id,
                        BookId = detail.BookId,
                        Price = detail.Book.Price,
                        Quantity = detail.Quantity,
                        Title = detail.Book.Title,
                    });
                }                
                
                model.Add(new AdminOrdersVM()
                {
                    Id = item.Id,
                    AddDate = item.AddDate,
                    TotalPrice = item.TotalPrice,
                    UserId = item.UserId,
                    UserName = item.UserName,
                    OrderDetailVMs = OrderDetailListVM
                });
                
            }
            
            if (model.Count == 0)
            {
                TempData["EmptyOrder"] = "Sipariş Yoktur !";
            }
            return View(model);
        }
    }
}
