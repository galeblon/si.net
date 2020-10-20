using System.Linq;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace demo.Tools
{
    public class ControllerNameAttributeConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNameAttributeConvention = controller.Attributes.OfType<ControllerNameAttribute>().SingleOrDefault();

            
            if(controllerNameAttributeConvention != null) {
                controller.ControllerName = controllerNameAttributeConvention.Name;
            }
        }
    }
}