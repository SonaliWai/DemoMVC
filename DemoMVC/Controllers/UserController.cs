using DemoMVC.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var userService = new UserService();
            var users = userService.GetAll();

            return View(users);
        }
        public IActionResult Details(int id)
        {
            var userService = new UserService();
            var user = userService.GetById(id);

            return View(user);
        }
    }
}
