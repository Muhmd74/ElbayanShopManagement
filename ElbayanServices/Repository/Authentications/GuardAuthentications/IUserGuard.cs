using System;

namespace ElbayanServices.Repository.Authentications.GuardAuthentications
{
    public interface IUserGuard
    {
       bool IsAuthorize(Guid employeeId, string roleName);
    }
}
