using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsssDealer.Models.CarsssModels
{
    public class Sales
    {
        public int Id { get; set; }

        public double Discount { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public Customers Customers { get; set; }
        public Carsss Carsss { get; set; }
    }
}
