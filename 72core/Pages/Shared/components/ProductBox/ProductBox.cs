using _72core.Models;
using _72core.Services;
using Microsoft.AspNetCore.Mvc;

namespace _72core.Pages.Shared.components.ProductBox
{
   
    public class ProductBox : ViewComponent
    {
        ProductListService productsService;

        public ProductBox(ProductListService _products)
        {
            productsService = _products;
        }

        public IViewComponentResult Invoke(bool xapxep = true)
        {

          

            List<Product> products = null;

            if (xapxep == true)
            {
                products = productsService.product.OrderBy(x=>x.Price).ToList();
            }
            else
            {
                products = productsService.product.OrderByDescending(x => x.Price).ToList();
            }
            return View(products);
        }
      
    }
}
