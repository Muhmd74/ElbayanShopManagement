using System.Data.SqlClient;

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
            var builder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "ElBayan",
                IntegratedSecurity = true,
                DataSource = @".\SQLEXPRESS",
                MultipleActiveResultSets = true,
                ApplicationName = "Elbayan"
            };
            return builder.ConnectionString;

        }
    }
}
