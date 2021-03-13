//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ElbayanDatabase.ConnectionTools;
//using ElbayanServices.Common;

//namespace ElbayanServices.Repository.Employees.EmployeePermession.Setting
//{
//    public class UserSettingTemplate
//    {
//        private readonly ConnectionOption _connectionOption;

//        public UserSettingTemplate(ConnectionOption connectionOption)
//        {
//            _connectionOption = connectionOption;
//        }

//        public static byte[] GetPropertyValue(string propName, Guid profileId)
//        {
//            var context = new ConnectionOption();

//            var value = context.SettingProfileProperties.FirstOrDefault(d =>
//                d.PropertyName == propName
//                && d.SettingProfileId == profileId);
//            if (value != null)
//            {
//                return value.PropertyValue.ToArray();
//            }

//            return null;

//        }



//    }

//    public class SettingTemplate
//    {
//        public Guid ProfileId { get; set; }

//        public SettingTemplate(Guid profileId)
//        {
//            ProfileId = profileId;
//        }

//        public SalesSetting Sales;
//        public GeneralSetting General;
//    }
//    public class GeneralSetting
//    {
//        public Guid ProfileId { get; set; }

//        public GeneralSetting(Guid profileId)
//        {
//            ProfileId = profileId;
//        }
//        public int DefaultRowStore { get { return StaticGenerator.FromByteArray<int>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//        public bool CanChangeDrawer { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//        public bool CanChangeCustomer { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//        public bool CanDeleteItem { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//    }
//    public class SalesSetting
//    {
//        public Guid ProfileId { get; set; }

//        public SalesSetting(Guid profileId)
//        {
//            ProfileId = profileId;
//        }
//        public int DefaultRowStore {get { return StaticGenerator.FromByteArray<int>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }
//        public bool CanChangeDrawer { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//        public bool CanChangeCustomer { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//        public bool CanDeleteItem { get { return StaticGenerator.FromByteArray<bool>(UserSettingTemplate.GetPropertyValue(StaticGenerator.GetLineNumber(), ProfileId)); } }

//    }
//}
