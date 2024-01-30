using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLessonITProger.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
