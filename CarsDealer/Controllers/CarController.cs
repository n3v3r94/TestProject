


namespace CarsssDealer.Controllers
{
    using CarsssDealer.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using CarsssDealer.Models.CarsssModels;

    public class CarController : Controller
    {

        private readonly ApplicationDbContext context;

        public CarController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult  Car()
        {
            return View();
        }

       // [HttpPost]
       // public IActionResult Car(Carsss Carsss)
       // {
       //     context.Carsss.Add(Carsss);
       //     context.SaveChanges();
       //
       //     return RedirectToAction("Index");
       // }
    }
}
