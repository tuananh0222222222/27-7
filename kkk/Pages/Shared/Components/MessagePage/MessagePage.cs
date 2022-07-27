using Microsoft.AspNetCore.Mvc;


namespace hihis
{
    [ViewComponent]
    public class MessagePage : ViewComponent
    {
        public MessagePage()
        {
        }

        public class Message
        {
            public string Title { get; set; } = " ";

            public string HtmlContent { get; set; } = "";

            public string UrlRedirect { get; set; } = "/";

            public int SecondWait { get; set; } = 3;
        }

        public IViewComponentResult Invoke(Message message)
        {
            // Thiết lập Header của HTTP Respone - chuyển hướng về trang đích
           this.HttpContext.Response.Headers.Add("REFRESH", $"{message.SecondWait}; {message.UrlRedirect}");
            return View(message);
        }

    }
}