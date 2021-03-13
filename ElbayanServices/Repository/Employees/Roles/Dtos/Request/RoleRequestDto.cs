using System;

namespace ElbayanServices.Repository.Employees.Roles.Dtos.Request
{
    public class RoleRequestDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}