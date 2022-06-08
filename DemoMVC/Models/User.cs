using System;

namespace DemoMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Pan { get; set; }
        public string? Address { get; set; }
        public char Gender { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public int DepartmentRefId { get; set; }
    }
}
