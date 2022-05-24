using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team2.Models;

namespace Team2.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext context { get; set; }
        public ProductController(ProductContext ctx)
        {
            context = ctx;
        }

        List<CartItem> CartItems = new List<CartItem>();

        [HttpGet]
        public IActionResult Order()
        {
            var menu = context.Products.OrderBy(m => m.ProductID).ToList();
            return View(menu);
        }

        public IActionResult Cart()
        {
            ViewBag.Subtotal = 0m;
            foreach (var cartitem in context.Cart)
            {
                ViewBag.Subtotal += cartitem.Subtotal;
            }
            var cart = context.Cart.OrderBy(m => m.CartID).ToList();
            return View(cart);
        }

        public IActionResult Add(string photo, string name, decimal price)
        {
            CartItem item = new CartItem();
            item.ProductPhoto = photo;
            item.ProductName = name;
            item.ProductPrice = price;
            int checker = 0;
            foreach (var cartitem in context.Cart)
            {
                if (item.ProductName == cartitem.ProductName)
                {
                    checker++;
                    cartitem.Quantity++;
                    cartitem.Subtotal = cartitem.ProductPrice * cartitem.Quantity;
                    context.Cart.Update(cartitem);
                }
            }
            if (checker == 0)
            {
                item.Quantity = 1;
                item.Subtotal = item.ProductPrice * item.Quantity;
                context.Cart.Add(item);
            }
            context.SaveChanges();
            return RedirectToAction("Order");
        }

        public IActionResult Remove(int id)
        {
            foreach (var cartitem in context.Cart)
            {
                if (id == cartitem.CartID)
                {
                    context.Cart.Remove(cartitem);
                }
            }
            context.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public IActionResult Checkout(decimal subtotal)
        {
            ViewBag.Subtotal = subtotal;
            ViewBag.Tax = subtotal * 0.0875m;
            ViewBag.Total = ViewBag.Subtotal + ViewBag.Tax;
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Checkout model, decimal subtotal)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Subtotal = 0m;
                ViewBag.Tax = 0m * 0.0875m;
                ViewBag.Total = ViewBag.Subtotal + ViewBag.Tax;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Subtotal = subtotal;
                ViewBag.Tax = subtotal * 0.0875m;
                ViewBag.Total = ViewBag.Subtotal + ViewBag.Tax;
                return View(model);
            }
        }
    }
}
