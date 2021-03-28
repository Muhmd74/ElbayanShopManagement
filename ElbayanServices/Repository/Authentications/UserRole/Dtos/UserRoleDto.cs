using System;

namespace ElbayanServices.Repository.Authentications.UserRole.Dtos
{
    public class UserRoleDto
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid EmployeeId { get; set; }
    }
}