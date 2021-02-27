using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Customers.Poses.Dtos
{
   public class PosDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? BuildingId { get; set; }

    }
   public class PosDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? BuildingId { get; set; }
        public string BuildingName { get; set; }

    }
}
