using demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class ResultsController : Controller
    {
        // FileProvider -> pliki
        // 

        [HttpGet]
        public BinderTester FirstAction() {
            return new BinderTester {
                Email = "test@test.pl",
                Phone = "123123123",
                Id = 1
            };
        }

        public IActionResult Action2() {
            return BadRequest();    // kod 400
        }

        public IActionResult Action3() {
            return Challenge(); // kod 401
        }

        public IActionResult Action4() {
            return Content("cokolwiek"); // status 200
        }

        public IActionResult Action5() {
            return Created("https://url", new BinderTester{ Email = "tester", Phone = "1231231", Id=5 }); // 201
        }

        public IActionResult Action6() {
            return Forbid();    // 403
        }

        public IActionResult Action7() {
            return NotFound(); // 404
        }

        public IActionResult Action8() {
            return RedirectToAction(nameof(FirstAction));
            // return RedirectToAction("Index", nameof(SecondController));
            // return RedirectToRoute("/ciasteczka/reksio");
        }

        public IActionResult Action9() {
            return SignIn(new System.Security.Claims.ClaimsPrincipal(), new Microsoft.AspNetCore.Authentication.AuthenticationProperties(), "");
        }

        public IActionResult Action10() {
            return View();
        }

        public IActionResult Action11() {
            // widoki komlpetn, partiale, komopnenty
            return ViewComponent("someComponent");  // 200 i widok czesciowy
        }
    }

}