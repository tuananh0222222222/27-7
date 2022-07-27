using hihis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kkk.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult Onpost()
        {
            var mess = new MessagePage.Message();
            mess.Title = "Thong bao";
            mess.HtmlContent = "Dang ky thanh cong chuyen ve trang dang nhap";
            mess.SecondWait = 2;
            mess.UrlRedirect = "/";
            return ViewComponent("MessagePage", mess);
        }

    }
}