using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace core027.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [Display(Name = "Ho ten")]
        public string username { set; get; } = "khuat";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? id)
        {
            if(id != null)
            {
                ViewData["home"] = $"day la san pham {id}";
            }                   
            else                 
            {                      
                ViewData["home"] = "day la  trang san pham ";
            }
        }
    }
}