using kkk.Model;
using kkk.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace kkk.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ILogger<ProductModel> logger;
        public readonly ProductService productService;

        public ProductModel(ILogger<ProductModel> _logger, ProductService _productService)
        {
            logger = _logger;
            productService = _productService;
        }

        public Product product { get; set; }

        public void OnGet(int? Id)
        {
            if (Id != null)
            {
                ViewData["title"] = $"san pham {Id}";
                product = productService.Find(Id.Value);
            }
            else
            {
                ViewData["title"] = "danh sach san pham";

            }
            
        }

        public IActionResult OnGetLastProduct()
        {
            ViewData["title"] = "san pham cuoi";
            product = productService.AllProduct().LastOrDefault();
            if(product != null)
            {
                return Page();
            }
            else
            {
                return Content( "khong thay sp");
            }
        }

        public IActionResult OnGetRemove()
        {
            productService.AllProduct().Clear();
            return RedirectToPage("User");
        }

        public IActionResult OnGetLoad()
        {
            productService.LoadProduct();
            return RedirectToPage("User");
        }

        public IActionResult OnPostDelete(int? Id)
        {
            if(Id !=null)
            {
                productService.Find(Id.Value);

                if(product != null)
                {
                    productService.AllProduct().Remove(product);
                }
            }    
            
            return RedirectToPage("User", new {Id = string.Empty});
        }
    }
}
