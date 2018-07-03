


namespace CarsssDealer.Models.CarsssModels
{

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customers
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

       
        public bool IsYoungDriver { get; set; }

        public List<Sales> Sales { get; set; } = new List<Sales>();
    }
}
