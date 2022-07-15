using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        [Route("/menu")]
        public IActionResult Index()
        {
            using (PizzaContext context = new PizzaContext())
            {

                List<Pizza> pizzaList = context.Pizzas.ToList();

                return View(pizzaList);
            }
        }

        [HttpGet]
        [Route("/menu/{id?}")]
        public IActionResult Details(int id)
        {
            using (PizzaContext context = new PizzaContext())
            {
                Pizza current = context.Pizzas.Where(pizza => pizza.Id == id).FirstOrDefault(); // in modo che possa restituire null

                if (current == null)
                {
                    return NotFound(View("Error"));
                }
                else
                {
                    return View(current);
                }
            }
        }
    }
}
