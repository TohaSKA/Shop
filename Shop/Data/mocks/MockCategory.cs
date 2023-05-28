using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> ALLCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Cursuri populare", desc = "Cele ma popullare cursuri in Moldova"},
                    new Category { categoryName = "Cursuri mai putin populare", desc = "Cursurile ce nu dispun de o popularitate inalta"}
                }; 
            }
        }
    }
}
