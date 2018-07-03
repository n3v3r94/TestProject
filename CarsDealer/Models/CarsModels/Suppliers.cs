

namespace CarsssDealer.Models.CarsssModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Suppliers
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public  string Name { get; set; }

        public bool IsImporter { get; set; }

        public List<Parts> Parts { get; set; } = new List<Parts>();
    }
}
