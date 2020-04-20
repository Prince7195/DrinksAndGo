using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data;
using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository, AppDBContext context)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
            DbInitializer.Seed(context);
        }
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All Drinks";
            }
            else
            {
                if(string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks.Where(d => d.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                }
                else
                {
                    drinks = _drinkRepository.Drinks.Where(d => d.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);
                }
                currentCategory = _category;
            }
            var drinksListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(drinksListViewModel);
        }
    }
}