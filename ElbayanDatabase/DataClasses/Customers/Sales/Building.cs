using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElbayanDatabase.DataClasses.Customers.Sales
{
   public class Building
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<POS> Poses { get; set; }

    }
}
