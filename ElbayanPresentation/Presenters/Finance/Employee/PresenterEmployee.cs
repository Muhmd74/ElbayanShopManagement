using ElbayanServices.Repository.Employees.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayaNPresentation.Presenters.Finance.Employee
{
    public class PresenterEmployee
    {
        private readonly IViewEmployee _view;
        private readonly EmployeeService employeeService = new EmployeeService(new ElbayanDatabase.ConnectionTools.ConnectionOption());
        public PresenterEmployee(IViewEmployee view)
        {
            _view = view;
        }


        // CRUD:
        // 1. Create

    }
}
