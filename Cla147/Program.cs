

using System.Net;

namespace Program
{
    class Program
    {

        public static string DowloadWebPage(string url, bool rs)
        {


            using (var client = new WebClient())

            {
                {
                    Console.WriteLine("bat dau tai ve");
                    string Content = client.DownloadString(url);
                    Thread.Sleep(2000);

                    if (rs)
                    {
                        Console.WriteLine(Content.Substring(0, 1500));
                    }

                    return Content;
                }

            }
        }

            public static void TestDowload()
            {
                string url = "https://vlxx.sex/";
                DowloadWebPage(url, true);
                Console.WriteLine("do something ....");
            }
            public static void Main(string[] args)
            {

                TestDowload();

            }
        }
    }