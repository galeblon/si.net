using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace demo.Controllers
{

    [Route("/filters/[action]")]
    // Swagger nie radzi sobie z kontrolerem ktory jest jednoczesnnie filtrem
    [FilterDemo]
    public class FilterDemoController
    {
        [HttpGet("Reksio")]
        public string Reksio() {
             System.Console.WriteLine("Wewnątrz akcji");
            return "rezultat";
        }

        private class FilterDemo : ActionFilterAttribute
        {
            public override void OnActionExecuted(ActionExecutedContext context)
            {
                System.Console.WriteLine("Po wykonaniu akcji");
            }

            public override void OnActionExecuting(ActionExecutingContext context)
            {
                System.Console.WriteLine("Przed wejściem do akcji");
            }
        }
    }
}