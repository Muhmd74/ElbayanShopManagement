using System;

namespace ElbayanServices.Repository.Employees.Building.Dtos
{
  public  class BuildingDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
    }
}
