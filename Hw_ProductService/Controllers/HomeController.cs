using Hw_ProductService.Models;
using Hw_ProductService.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace Hw_ProductService.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ProductService _products;

        public HomeController(ProductService product)
        {
            _products = product;
        }

        public IActionResult Index()
        {
            return View(_products.GetProducts());
        }

        public IActionResult EditProduct(int productId)
        {
            var currentProduct = _products.GetProduct(productId);
            if (currentProduct != null)
            {
                ViewBag.Categories = new string[] { "Headphones", "Laptop", "Smartphone", "Smart Watch" };
                return View(currentProduct);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                _products.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }
        
    }
}
