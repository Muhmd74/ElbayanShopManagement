using System;

namespace ElbayanServices.Repository.Products.SubCategory.Dtos
{
   public class SubCategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
