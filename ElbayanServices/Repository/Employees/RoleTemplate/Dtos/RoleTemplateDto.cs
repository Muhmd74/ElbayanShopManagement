using System;
using System.Collections.Generic;

namespace Optics.Utility.Repositories.Members.RoleTemplate.Dtos
{
    public class RoleTemplateDto
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid TemplateId { get; set; }
    }

    public class RoleTemplateToUserDto
    {
        public Guid EmployeeId { get; set; }
        public List<RoleTemplateDto> Roles { get; set; }
    }
    public class RoleTemplateToUserRoleDto
    {
        public Guid EmployeeId { get; set; }
        public List<Guid> Roles { get; set; }
    }
}