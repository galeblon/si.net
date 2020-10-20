
using demo.Tools;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class NestedController { }


    namespace Nested
    {
        
        [ControllerName("NestedFifthController")]       // adnotacja zmieniająca konwencję 
        public class SecondController {

            [ActionName("Reksio")]
            public string Index() {
                return "Zgadnij jaki jest mój adres";       // url -> 
            }
        }
    }
}