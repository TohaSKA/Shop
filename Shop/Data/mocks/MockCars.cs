using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Data.mocks
{
    public class MockCars : IALLCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, Frumos si Linistit automobil al companiei Tesla",
                        img = "/img/Tesla.png",
                        price =450000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.ALLCategories.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Linistit si simplu",
                        longDesc = "Convenabil pentru viata de la oras",
                        img = "/img/Ford Fiesta.png",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.ALLCategories.Last()
                    },
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, Frumos care arata cine este el pe drum",
                        img = "/img/BMW M3.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.ALLCategories.Last()
                    },
                    new Car {
                        name = "Mercedes C class",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, bun concurent al BMW",
                        img = "/img/Mercedes.png",
                        price = 45000,
                        isFavorite = false,
                        available = false,
                        Category = _categoryCars.ALLCategories.Last()
                    },
                    new Car {
                        name = "Chevrolet Camaro",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, Coupe, pentru zile de weekend",
                        img = "/img/Camaro.png",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.ALLCategories.Last()
                    }

                };
            }

        } 
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
