using demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [Route("Results")]
    public class ResultsController : Controller
    {
        // FileProvider -> pliki
        // 

        [HttpGet("FirstAction")]
        public BinderTester FirstAction() {
            return new BinderTester {
                Email = "test@test.pl",
                Phone = "123123123",
                Id = 1
            };
        }


        [HttpGet("Action2")]
        public IActionResult Action2() {
            return BadRequest();    // kod 400
        }

        [HttpGet("Action3")]
        public IActionResult Action3() {
            return Challenge(); // kod 401
        }

        [HttpGet("Action4")]
        public IActionResult Action4() {
            return Content("cokolwiek"); // status 200
        }

        [HttpGet("Action5")]
        public IActionResult Action5() {
            return Created("https://url", new BinderTester{ Email = "tester", Phone = "1231231", Id=5 }); // 201
        }

        [HttpGet("Action6")]
        public IActionResult Action6() {
            return Forbid();    // 403
        }

        [HttpGet("Action7")]
        public IActionResult Action7() {
            return NotFound(); // 404
        }

        [HttpGet("Action8")]
        public IActionResult Action8() {
            return RedirectToAction(nameof(FirstAction));
            // return RedirectToAction("Index", nameof(SecondController));
            // return RedirectToRoute("/ciasteczka/reksio");
        }

        [HttpGet("Action9")]
        public IActionResult Action9() {
            return SignIn(new System.Security.Claims.ClaimsPrincipal(), new Microsoft.AspNetCore.Authentication.AuthenticationProperties(), "");
        }

        [HttpGet("Action10")]
        public IActionResult Action10() {
            return View();
        }

        [HttpGet("Action11")]
        public IActionResult Action11() {
            // widoki komlpetn, partiale, komopnenty
            return ViewComponent("someComponent");  // 200 i widok czesciowy
        }
    }

}