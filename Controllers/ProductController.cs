using Microsoft.AspNetCore.Mvc;
using WebApplication210924_ProductDetails.Models;

namespace WebApplication210924_ProductDetails.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Пример продукта",
                Description = "Описание продукта",
                Price = 99.99M
            };

            return View("ProductDetails", product);
        }

        [HttpPost]
        public IActionResult AddReview(string review)
        {
            return RedirectToAction("Details", new { id = 1 });
        }
    }
}
