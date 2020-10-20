using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace demo.Domain.Entities
{

    // [Bind("Email, Phone")]
    public class BinderTester {
        // [ModelBinder]
        public string Email {get; set; }

        // [ModelBinder]
        public int Id {get; set;}

        // [ModelBinder]
        // [BindNever]
        public string Phone {get; set;}

        public override string ToString()
        {
            return "Email: "+Email+", Id: "+Id+", Phone: "+Phone;
        }
    }
    
}