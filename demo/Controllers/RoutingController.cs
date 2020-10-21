using System.Collections.Generic;
using System.Linq;
using demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace demo.Controllers
{
    [Route("routing")]
    // [Produces("application/xml")]
    public class RoutingController : Controller
    {
        private Dictionary<long, Product> Catalog;
        public RoutingController() {
            InitializeCatalog();        // na 3 wykładzie - naprawiamy stan katalogu po zmianie
        }

        [HttpGet("")]
        public IActionResult List() {
            return View("List", Catalog);
        }

        [HttpGet("Delete/{id:required}")]
        public IActionResult Delete(int id) {
            bool status = DeleteProduct(id);
            TempData["message"] = status ? "Product was deleted" : "Can not find product with the specified id";

            return RedirectToAction("");
        }

        [HttpGet("GetProduct/{id:required}")]   // dlaczego wołam URL/id -> dostaje tę akcję
        public IActionResult GetProduct(int id) {
            Product p = null;
            if(!Catalog.TryGetValue(id, out p)) {
                TempData["message"] = "I can not find product with the specified id";
                return RedirectToAction("");
            }
            return View("Details", p);
        }

        [HttpPost("Add")]
        public IActionResult Add([Bind("id,Name,Price,Category")] Product product) {
            if(product != null && !Catalog.ContainsKey(product.id)) {
                Catalog.Add(product.id, product);
                TempData["message"] = "Product was successfully registered.";
            } else {
                TempData["message"] = "We can not register the specified product.";
            }
            return RedirectToAction("");
        }

        [HttpPost("add-validation")]
        [ActionName("validation")]
        public IActionResult AddWithValidation([Bind("id,Name,Price,Category")] Product product) {
            if(!ModelState.IsValid) {
                TempData["message"] = "You have errors in the form";
                return RedirectToAction("");
            }

            Catalog.Add(product.id, product);
            TempData["message"] = "Great!";
            return RedirectToAction("");
        }

        [HttpPost("AddJson")]
        public IActionResult AddJson([FromBody] Product product) {
            if(product != null && !Catalog.ContainsKey(product.id)) {
                Catalog.Add(product.id, product);
                TempData["message"] = "Product was successfully registered.";
            } else {
                TempData["message"] = "We can not register the specified product.";
            }
            return RedirectToAction("");
        }

        
        
        [HttpGet("CheckPrime/{number:primeint}")]
        public IActionResult CheckPrime(int number) {
            TempData["message"] = "The number is prime";
            return RedirectToAction("");
        } 


        [HttpGet("CatalogJson")]
        public IActionResult ListJson() {
            return Json(Catalog, new JsonSerializerSettings {
                Formatting = Formatting.Indented
            });
        }

        [HttpGet("CatalogXml")]
        public IActionResult ListXml() {
            List<Product> products = Catalog.Values.Select(x => new Product(x.id, x.Name, x.Price, x.Category)).ToList();
            return Ok(products);
        } // Accept w Headerze : application/json lub application/xml


        ////
        /// Private part
        ////

        private void InitializeCatalog()
        {
            // Catalog = new List<Product>();
            Catalog = new Dictionary<long, Product>();
            Catalog.Add(1, new Product(1, "Samsung Galaxy S10", "3000.20", "Smartphone"));
            Catalog.Add(2, new Product(2, "Apple iPhone XS Max", "4900.00", "Smartphone"));
            Catalog.Add(3, new Product(3, "Apple MacBook Pro", "9900.00", "Laptop"));
        }

        private bool DeleteProduct(int id)
        {
            if(!Catalog.ContainsKey(id)) return false;
            Catalog.Remove(id);
            return true;
        }
    }
}