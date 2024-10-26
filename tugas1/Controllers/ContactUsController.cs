using Microsoft.AspNetCore.Mvc;

namespace tugas1.Controllers
{
    public class ContactUsController : Controller
    {
        
    private readonly string email = "perpusuye@Gmail.com";
        private readonly string address = "Jakarta, Indonesia";


        public IActionResult Index()
        {
            ViewData["EmailAddress"] = email;
            ViewBag.Address = address;

            return View();


        }

    }
}
