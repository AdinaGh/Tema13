using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Incepeti downloadarea fisierului " );
                    webClient.DownloadFile("https://i.ebayimg.com/images/g/4QgAAOSw7FRWUUXp/s-l300.jpg", "../../DownloadedFile");
                    Console.WriteLine("Downloadarea a fost cu success ");
                }
                catch (ArgumentException)
                {

                    Console.WriteLine("Ati introdus un URL gol ");
                }
                catch(WebException)
                {
                    Console.WriteLine("Ati introdus un URL invalid ");
                }
                catch(NotSupportedException)
                {
                    Console.WriteLine("Nu se permit downloadari simultane ");
                }
            }
        }
    }
}
