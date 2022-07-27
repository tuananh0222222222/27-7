
using core027.Model;
using Microsoft.AspNetCore.Mvc;

namespace Components.Product
{
    public class ProductList : ViewComponent
    {



        public IViewComponentResult Invoke()
        {
        
            return View();
        }
    }
}
