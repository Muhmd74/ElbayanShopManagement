using System;

namespace ElbayanServices.Repository.Employees.Roles.Dtos.Response
{
    public class RoleResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}