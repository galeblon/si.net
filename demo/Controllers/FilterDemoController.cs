using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Controllers
{

    [Route("/filters/[action]")]
    public class FilterDemoController : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("Po wykonaniu akcji");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("Przed wejściem do akcji");
        }


        public string Reksio() {
             System.Console.WriteLine("Wewnątrz akcji");
            return "rezultat";
        }
    }
}