using System;

namespace ElbayanServices.Repository.Authentications.Roles.Dtos
{
    public class RoleRequestDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}