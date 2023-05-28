using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Controllers
{
    public class CarsController : Controller {

        private readonly IALLCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IALLCars iALLCars, ICarsCategory iCarsCat)
        {
            _allCars = iALLCars;
            _allCategories = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{Category}")]
        public  ViewResult List (string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("limbi de studiere mai complicata", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Cursuri populare")).OrderBy(i => i.id);
                    currCategory = "Cursuri populare";
                }
                else if (string.Equals("limbi de studiere mai simpla", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Cursuri mai putin populare")).OrderBy(i => i.id);
                    currCategory = "Cursuri mai putin populare";

                }

                currCategory = _category;

                
            }
            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };




            ViewBag.Title = "Pagina cu cursuri";
            
            return View(carObj);
        }
    }
}
