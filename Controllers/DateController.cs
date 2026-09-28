using Microsoft.AspNetCore.Mvc;

namespace Bai1_Date.Controllers
{
    public class DateController : Controller
    {
        // /Date/Weekend (cũng là trang mặc định)
        public IActionResult Weekend()
        {
            return View();
        }
    }
}
