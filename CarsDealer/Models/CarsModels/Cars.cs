
namespace CarsssDealer.Models.CarsssModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    
    public class Carsss
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0,1000000)]
        public int TravelledDistance { get; set; }

        public List<Sales> Sales { get; set; } = new List<Sales>();

        public List<PartCarsss> Parts { get; set; } = new List<PartCarsss>();

    }
}
