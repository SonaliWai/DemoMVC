using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Models.Services
{
    public class DepartmentService
    {
        readonly List<Department> _departments = new()
        {
            new Department
            {
                Id = 1,
                Name = "Science",
                Description = "Computer"
            },
            new Department
            {
                Id = 2,
                Name = "Soft ",
                Description = "Developer"
            }
        };
        public List<Department> GetAll()
        {
            return _departments;
        }
        public Department GetById(int id)
        {

            var employee = _departments.Single(e => e.Id == id);
            return employee;
        }
    }
}
