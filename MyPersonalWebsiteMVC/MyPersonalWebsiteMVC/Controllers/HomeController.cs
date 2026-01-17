using Microsoft.AspNetCore.Mvc;
using MyPersonalWebsiteMVC.Models;

namespace MyPersonalWebsiteMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Profile profile = new Profile
            {
                FullName = "Bouie Andrei R. Martinez",
                Age = 20,
                FavoriteColor = "Black",
                ShortBio = "A Computer Science student with a growing interest in web development and software design.",
                Motivation = "I started pursuing Computer Science because I was fascinated by how technology works behind the scenes. The continuous evolution of software, hardware, and digital systems motivated me to learn how these technologies are built and improved over time.",
                Goals = "My goal is to strengthen my foundation in programming and system design while continuously exploring modern technologies that shape how people interact with software.",
                Interests = "Web development, software architecture, user interface design, and emerging technologies."
            };

            return View(profile);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult Reflection()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
