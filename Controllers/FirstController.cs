using APP.Services;
using Microsoft.AspNetCore.Mvc;

namespace APP.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;
        public FirstController(ILogger<FirstController> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public string Index()
        {
            // _logger.Log(LogLevel.Warning,"Thong bao abc");
            _logger.LogError("Thong bao");
            _logger.LogWarning("Thong bao");
            _logger.LogDebug("Thong Bao");
            _logger.LogInformation("Index Action");
            return "Toi la Index cua First";
        }

        public void Nothing()
        {
            _logger.LogInformation("Nothing action");
            Response.Headers.Add("Hi", "Xin chao cac ban");
        }
        // public object Anything() => DateTime.Now;
        public object Anything() => Math.Sqrt(2);

        public IActionResult Readme()
        {
            var content = @"
                Helloooo




                ASP
            ";
            return Content(content, "text/html");
        }

        public IActionResult Bird()
        {
            string filePath = Path.Combine(Startup.ContentRootPath, "Files", "goku.jpg");
            var bytes = System.IO.File.ReadAllBytes(filePath);
            return File(bytes, "image/jpg");
        }

        public IActionResult IPhonePrice()
        {
            return Json(
                new
                {
                    ProductName = "IPhone X",
                    Price = 1000
                }
            );
        }

        public IActionResult Privacy()
        {
            var url = Url.Action("Privacy", "Home");
            _logger.LogInformation("chuyen huong den " + url);
            return LocalRedirect(url);
        }
        public IActionResult Google()
        {
            var url = "https://www.google.com.vn/";
            _logger.LogInformation("chuyen huong den " + url);
            return Redirect(url);
        }

        public IActionResult HelloView(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                username = "guest";
            }
            // return View("/MyView/xinchao1.cshtml", username);  

            // xinchao2.cshtml -> /View/First
            // return View("xinchao2",username) ;

            // /View/Controller/Action.cshtml
            // return View((object)username);

            return View("xinchao3", username);
        }

        [TempData]
        public string StatusMessage { set; get; }

        [AcceptVerbs("POST","GET")]
        public IActionResult ViewProduct(int? id)
        {
            var product = _productService.Where(
                p => p.Id == id
            ).FirstOrDefault();
            if (product == null)
            {
                StatusMessage = "Khong tim thay san pham";
                return Redirect(Url.Action("Index", "Home"));
            }
            // return Content($"San pham ID={id}");

            // Model
            // return View(product);

            // ViewData
            // this.ViewData["product"] = product;
            // ViewData["Title"] = product.Name;
            // return View("ViewProduct2");

            // TempData["Thongbao"] = "1234r";

            ViewBag.product = product;
            return View("ViewProduct3");
        }


    }
}