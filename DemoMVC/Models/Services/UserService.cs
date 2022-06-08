using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMVC.Models.Services
{
    public class UserService
    {
        readonly List<User> _users = new()
        {
            new User
            {
                Id = 1,
                FirstName = "Akshay",
                LastName = "Kumar",
                DateOfBirth = new DateTime(1972, 4, 25),
                Pan = "ABCDE0000M",
                Address = "ngr",
                Gender = 'M',
                MobileNumber = "7756483929",
                Email = "ak@21gmail.com",
                Comment = "non",
                DepartmentRefId = 3
            },
            new User
            {
                Id = 3,
                FirstName = "Raveena",
                LastName = "Tandon",
                DateOfBirth = new DateTime(1975, 10, 2),
                Pan = "UVWXY1234O",
                Address = "Pune",
                Gender = 'F',
                MobileNumber = "9011410654",
                Email = "RT12@gmail.com",
                Comment = "no",
                DepartmentRefId = 2
            }
        };

        public List<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {

            var employee = _users.Single(e => e.Id == id);
            return employee;
        }
    }
}
