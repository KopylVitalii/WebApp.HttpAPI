using Microsoft.AspNetCore.Mvc;
using WebApp.Services.Abstract;

namespace WebApp.HttpAPI.Controllers
{
    public class WebAppController : Controller
    {
        private readonly IWebAppService _webAppService;
        public WebAppController(IWebAppService webAppService)
        {
            _webAppService = webAppService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
