using challenge_backend_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace challenge_backend_3.Controllers
{
    public class ImportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(IFormFile arquivoTransacao)
        {
            return RedirectToAction("Index");
        }
    }
}
