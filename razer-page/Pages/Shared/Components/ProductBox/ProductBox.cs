using Microsoft.AspNetCore.Mvc;
using razer_page.Model;
using razer_page.Service;

namespace ProductBox
{

    public class ProductBox : ViewComponent
    {
        ProductListService productService;

        public ProductBox(ProductListService _productz)
        {
            productService = _productz;
        }

        public IViewComponentResult Invoke(bool xapsep = true)
        {

         

            List<Product> products = null;

            if (xapsep)
            {
                products = productService.product.OrderBy(x => x.Price).ToList();
            }
            else
            {
                products = productService.product.OrderByDescending(x => x.Price).ToList();
            }

            return View(products);
        }
    }
}
