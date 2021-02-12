using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.ConnectionTools
{
   public class ConnectionOption : DbContext
    {
        public ConnectionOption()
            : base(ConnectionString.Create())
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
