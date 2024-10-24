using System;
using System.Net;

namespace DownloadFileFromURL
{
    public class Program
    {
        static void Main()
        {
            var url = "http://www.devbg.org/img/Logo-BASD.jpg";
            string fileName = "D:\\Downloads\\viber_image_2023-05-11_13-40-32-747.jpg";
            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(url, fileName);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("The address or fileName parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}
