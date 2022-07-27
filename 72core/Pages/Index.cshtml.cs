

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XT;

namespace _72core.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            var message = new MessagePage.Message();
            message.Title = "thong bao";
            message.HtmlContent = "cam on ban da gui thong tin";
            message.SecondWait = 3;
            message.UrlRedict = "/Privacy";

            return ViewComponent("MessagePage",message);
        }
        //public IActionResult OnGet()
        //{
        //    return ViewComponent("ProductBox",false);
        //}
    }
}