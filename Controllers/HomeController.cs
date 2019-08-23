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

namespace GroceryStoreRewards.Controllers
{
    public class HomeController : Controller
    {
        private IRestRequest apiUrl;

        public async Task<IActionResult> IndexAsync()
        {
            var client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/1003464/ingredientWidget.json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "9aea809182msh45b6cdf8b73c98fp19e9bajsnd317d98d96aa");
            IRestResponse restresponse = client.Execute(request);
       
        //    HttpResponseMessage response = await client.GetAsync(apiUrl);
            var data = await response.Content.ReadAsStringAsync();
            var jsonResults = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(data);
            var results = jsonResults["results"][0];
            var location = results["name"]["count"];
       //     ViewBag.ApiKey = ApiKey.GOOGLE_API_KEY;
            return View(restresponse); //deserialize json 

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
