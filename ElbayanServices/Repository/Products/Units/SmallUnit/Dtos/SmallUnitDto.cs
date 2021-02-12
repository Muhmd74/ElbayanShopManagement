using System;

namespace ElbayanServices.Repository.Products.Units.SmallUnit.Dtos
{
  public  class SmallUnitDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
