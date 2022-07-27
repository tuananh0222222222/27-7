using _72core.Models;
using _72core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _72core.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ILogger<ProductModel> _Loger;

        public readonly ProductService _productServices;

        public ProductModel(ILogger<ProductModel> logger , ProductService productService)
        {
            _Loger = logger;
            _productServices = productService;
        }

        public Product product { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
               
                ViewData["title"] = $"day la sp : {id.Value}";
                product =_productServices.Find(id.Value);

            }
            else
            {
                ViewData["title"] = "trang san pham";
            }
        }
    }
}
