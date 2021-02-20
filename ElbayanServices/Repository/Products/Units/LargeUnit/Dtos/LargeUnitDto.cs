using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanServices.Repository.Products.Units.LargeUnit.Dtos
{
  public  class LargeUnitDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid Id { get; set; }
    }

  public class SmallUnitNameDto
  {
      public Guid SmallUnitId { get; set; }
      public string Name { get; set; }
  }
}
