namespace MvcDesign.Constrains
{
    public class CustomConstrain : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return true;
        }
    }
}

