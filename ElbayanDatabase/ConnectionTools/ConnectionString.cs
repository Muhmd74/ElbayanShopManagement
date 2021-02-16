using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.ConnectionTools
{
  public  class ConnectionString
    {
        public static string Create()
        {
            return GetConnectionDetails();
        }
        private static string GetConnectionDetails()
        {
            var buillder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "ElBayan",
                IntegratedSecurity = true,
                DataSource = @".",
                MultipleActiveResultSets = true,
                ApplicationName = "Elbayan"
            };
            return buillder.ConnectionString;

        }
    }
}
