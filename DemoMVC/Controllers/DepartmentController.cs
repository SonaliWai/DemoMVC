using DemoMVC.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            var departmentService = new DepartmentService();
            var departments = departmentService.GetAll();

            return View(departments);
        }
        public IActionResult Details(int id)
        {
            var departmentService = new DepartmentService();
            var department = departmentService.GetById(id);

            return View(department);
        }
    }
}
