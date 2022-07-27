using Microsoft.AspNetCore.Mvc;

namespace XT
{
    public class MessagePage : ViewComponent
    {
        public class Message
        {
            public string Title { get; set; } = "Thong bao";
            public string? HtmlContent { get; set; }
            public string UrlRedict { get; set; } = "/";
            public int SecondWait { get; set; } = 3;



        }

        public MessagePage() { }

        public IViewComponentResult Invoke(Message message)
        {
            HttpContext.Response.Headers.Add("REFRESH", $"{message.SecondWait};URL={message.UrlRedict}");
            return View(message);
        }

    }
}
