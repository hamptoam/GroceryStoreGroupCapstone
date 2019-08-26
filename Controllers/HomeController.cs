using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryStoreRewards.Models;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;
using GroceryStoreRewards.Data;

namespace GroceryStoreRewards.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            id = 1003464;

            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/" + id + "/ingredientWidget.json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "f2216af4f5msh71430f2e651f9dap1350a2jsn801bc5c5aa5f");
            var response = client.Execute(request);
            var data = response.Content;
            SpoonacularRecipeIngredients jsonResults = JsonConvert.DeserializeObject<SpoonacularRecipeIngredients>(data);


            foreach (Ingredient ingredient in jsonResults.ingredients)
            {
                var ing = new Ingredients();
                ing.Name = ingredient.name;
                ing.WeightValue = ingredient.amount.metric.value.ToString();
                ing.unit = Convert.ToInt32(ingredient.amount.metric.unit);
                _db.Add(ing);
                _db.SaveChanges();
            }

            return View(); //deserialize json 



        }

        public IActionResult About()
        {            
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
