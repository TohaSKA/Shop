using Shop.Data.interfaces;
using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Controllers
{
     public class HomeController: Controller
     {
        private  IALLCars _carRep;
       

        public HomeController(IALLCars carRep)
        {
            _carRep = carRep;
            
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }

    }
}


