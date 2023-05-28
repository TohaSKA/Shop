using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
           

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(content => content.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                      new Car
                      {
                          name = "Tesla Model S",
                          shortDesc = "Automobil rapid",
                          longDesc = "Rapid, Frumos si Linistit automobil al companiei Tesla",
                          img = "/img/Tesla.png",
                          price = 45000,
                          isFavorite = true,
                          available = true,
                          Category = Categories["Masini electrice"]
                      },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Linistit si simplu",
                        longDesc = "Convenabil pentru viata de la oras",
                        img = "/img/Ford Fiesta.png",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Masini clasice"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, Frumos care arata cine este el pe drum",
                        img = "/img/BMW M3.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Masini clasice"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, bun concurent al BMW",
                        img = "/img/Mercedes.png",
                        price = 45000,
                        isFavorite = false,
                        available = false,
                        Category = Categories["Masini clasice"]
                    },
                    new Car
                    {
                        name = "Chevrolet Camaro",
                        shortDesc = "Automobil rapid",
                        longDesc = "Rapid, Coupe, pentru zile de weekend",
                        img = "/img/Camaro.png",
                        price = 25000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Masini clasice"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary <string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Masini electrice", desc = "Cel mai actual tip de transport"},
                        new Category { categoryName = "Masini clasice", desc = "Masini cu motor cu ardere interna"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);

                }

                return category;
            }
        }
    }
}
