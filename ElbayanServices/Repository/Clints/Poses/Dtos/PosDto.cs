using System;

namespace ElbayanServices.Repository.Clints.Poses.Dtos
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
