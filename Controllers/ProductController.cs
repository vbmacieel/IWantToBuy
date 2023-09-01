using IWantToBuy.Models;
using IWantToBuy.Service;
using IWantToBuy.Util;
using Microsoft.AspNetCore.Mvc;

namespace IWantToBuy.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var productListSorted = _service.GetAllProducts()
                .OrderBy(product => product.Category);
            return View(productListSorted);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!LinkUtil.isValidUrl(product.ProductUrl))
            {
                ModelState.AddModelError("ProductUrlError",
                "The link to the product is not valid");
            }

            if (!LinkUtil.isImgValidUrl(product.ImageUrl))
            {
                ModelState.AddModelError("ProductImgUrlError",
                "The image link does not lead to an image");
            }

            if (ModelState.IsValid)
            {
                _service.SaveProduct(product);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var product = _service.GetProductFromId(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var product = _service.GetProductFromId(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (!LinkUtil.isValidUrl(product.ProductUrl))
            {
                ModelState.AddModelError("ProductUrlError",
                "The link to the product is not valid");
            }

            if (!LinkUtil.isImgValidUrl(product.ImageUrl))
            {
                ModelState.AddModelError("ProductImgUrlError",
                "The image link does not lead to an image");
            }

            if (ModelState.IsValid)
            {
                _service.Update(product);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _service.GetProductFromId(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Detele(int id)
        {
            _service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}