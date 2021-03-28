using System;
using System.Data.Entity;
using System.Linq;
using ElbayanDatabase.ConnectionTools;

namespace ElbayanServices.Repository.Authentications.GuardAuthentications
{
    public class UserGuardService : IUserGuard, IDisposable
    {
        private readonly ConnectionOption _context;

        public UserGuardService(ConnectionOption context)
        {
            _context = context;
        }

        public bool IsAuthorize(Guid employeeId, string roleName)
        {
            var user = _context.Employees.FirstOrDefault(d => d.Id == employeeId);
            if (user != null)
            {
                var userRoles = _context.EmployeeRoles
                    .Include(d => d.Role)
                    .Where(d => d.EmployeeId == employeeId).ToList();
                if (userRoles.Any(d => d.Role.Name == roleName))
                {
                    return true;
                }

                return false;

            }

            return false;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
