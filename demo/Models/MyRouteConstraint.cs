using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace demo.Models
{
    public class MyRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if ((values.ContainsKey(routeKey) == false) || (values[routeKey] == null)) { return false; }

            var value = values[routeKey].ToString();
            int number;
            if(int.TryParse(value, out number) == false) { return false; }

            return checkIsItPrime(number);
        }

        private bool checkIsItPrime(int number)
        {
            for(int i=2; i<number-1; i++) {
                if(number % i == 0) return false;
            }
            return true;
        }
    }
}