using System.Collections.Generic;
using System.Reflection;
using demo.Controllers;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;

namespace demo.Tools
{
    public class CustomActionSelector : IActionSelector
    {
        public ActionDescriptor SelectBestCandidate(RouteContext context, IReadOnlyList<ActionDescriptor> candidates)
        {
            var controllerActionDescriptor = new ControllerActionDescriptor();
            controllerActionDescriptor.ControllerName = typeof(SecondController).Name;
            controllerActionDescriptor.MethodInfo = typeof(SecondController).GetTypeInfo().GetMethod("Index");
            controllerActionDescriptor.ActionName = controllerActionDescriptor.MethodInfo.Name;
            return controllerActionDescriptor;
        }

        public IReadOnlyList<ActionDescriptor> SelectCandidates(RouteContext context)
        {
            return new List<ActionDescriptor>();
        }
    }
}