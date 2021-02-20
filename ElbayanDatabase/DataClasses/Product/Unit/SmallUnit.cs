using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElbayanDatabase.DataClasses.Product.Unit
{
   public class SmallUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid LargeUnitId { get; set; }
        public LargeUnit LargeUnit { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
