using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APP.Services;

namespace APP.Controllers
{
    [Area("ProductManage")]
    public class ProductController : Controller
    {
        private readonly ProductService _productServices;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductService productService, ILogger<ProductController> logger)
        {
            _productServices = productService;
            _logger = logger;
        }

        [Route("/cac-san-pham/{id?}")]
        public IActionResult Index()
        {
            var products = _productServices.OrderBy(p => p.Name).ToList();
            return View(products);
        }
    }
}