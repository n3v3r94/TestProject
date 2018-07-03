

namespace CarsssDealer.Models.CarsssModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Parts
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public double Price { get; set; }

        public int SupplierId { get; set; }

        public int PartCarsssId { get; set; }

        public Suppliers Suppliers { get; set; }

        public List<PartCarsss> PartCarsss { get; set; } = new List<PartCarsss>();
        
      
    }
}
