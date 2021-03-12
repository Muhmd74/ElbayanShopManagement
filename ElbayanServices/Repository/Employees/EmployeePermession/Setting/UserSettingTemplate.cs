using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Employees.EmployeePermession.Setting
{
   public class UserSettingTemplate
    {
        public Guid ProfileId { get; set; }

        public UserSettingTemplate(Guid profileId)
        {
            ProfileId = profileId;
        }

        public SalesSetting Sales;
        public GeneralSetting General;


    }

   public class GeneralSetting
   {
       public int DefaultRowStore { get; set; }
       public bool CanChangeDrawer { get; set; }
       public bool CanChangeCustomer { get; set; }
       public bool CanDeleteItem { get; set; }
    }
   public class SalesSetting
   {
       public int DefaultRowStore { get; set; }
       public bool CanChangeDrawer { get; set; }
       public bool CanChangeCustomer { get; set; }
       public bool CanDeleteItem { get; set; }
   }
}
