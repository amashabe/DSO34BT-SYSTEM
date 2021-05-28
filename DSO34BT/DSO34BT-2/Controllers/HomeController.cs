using DSO34BT_2.Models.DTOs;
using DSO34BT_2.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DSO34BT_2.Controllers
{
    public class HomeController : Controller
    {
        private UserRepository repository;

        public HomeController()
        {
            repository = new UserRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Users()
        {
            List<UserDto> users = repository.FindAll().ToList();

            return View("", users);
        }

        public ActionResult CreateUser()
        {
            UserDto userDto = new UserDto();
            return View("", userDto);
        }

        [HttpPost]
        public ActionResult CreateUser(UserDto userDto)
        {
            repository.Create(lastName: userDto.LastName, firstName: userDto.FirstName, age: userDto.Age, email: userDto.Email);

            ViewBag.Message = "Success";

            return RedirectToAction("Users");
        }
    }
}