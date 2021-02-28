using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks;
using Newtonsoft.Json;

namespace DrinkMaker.Controllers
{
    public class DrinkMakerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult DrinkActions(string drink)
        {
            List<String> actions = null;

            switch (drink.ToLower())
            {
                case "coffee":
                    var coffee = new Coffee();
                    actions = coffee.Actions();
                    break;

                case "lemontea":
                    var tea = new LemonTea();
                    actions = tea.Actions();
                    break;

                case "chocolate":
                    var chocolate = new Chocolate();
                    actions = chocolate.Actions();
                    break;

                default:
                    break;
                    //return JSon(Newtonsoft.Json.JsonSerializer())


            }

            return new JsonResult(actions);

        }

    }

}
