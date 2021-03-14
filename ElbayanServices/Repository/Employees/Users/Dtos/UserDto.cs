using System;

namespace ElbayanServices.Repository.Employees.Users.Dtos
{
   public class UserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Guid EmployeeId { get; set; }
        public string Mobile { get; set; }
    }
}
