using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDBContext _appDBContext;
        public DrinkRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public IEnumerable<Drink> Drinks => _appDBContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDBContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => _appDBContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
