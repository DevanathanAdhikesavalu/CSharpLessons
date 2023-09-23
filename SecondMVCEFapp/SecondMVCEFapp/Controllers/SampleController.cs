using Microsoft.AspNetCore.Mvc;

namespace SecondMVCEFapp.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
