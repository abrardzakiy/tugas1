using Microsoft.AspNetCore.Mvc;

namespace tugas1.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            // Informasi yang akan ditampilkan di halaman "About Me"
            ViewData["Title"] = "About Me";
            ViewData["Name"] = "Abrar Dzakiy Purnomo";
            ViewData["BirthDate"] = "March 30, 2001";
            ViewData["Location"] = "Ciracas, East Jakarta";
            ViewData["Hobby"] = "Going to the gym";
            ViewData["Idol"] = "King Jarip";

            return View();
        }
    }
}


