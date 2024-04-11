using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Genspil___Drive_access_Spiloversigten
{
    internal class Program
    {
        // Marks an Asynchronous method: I can execute multiple things at a time
        // and not have to finish executing the current thing in order to move on to next one. Useful for Http request
        static async Task Main(string[] args)
        {
            // URL of the publicly accessible text file in Google Drive
            string fileId = "1BWZME-CcRPyuUGS73lK6ZyAvt-iZBoBJ";
            string fileUrl = $"https://drive.google.com/uc?id={fileId}";

            // Download the contents of the text file through HttpClient method
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // I use GetStringAsync method to download the content of the txt.file to a string 
                    string fileContents = await client.GetStringAsync(fileUrl);

                    // Showcases the file content
                    Console.WriteLine(fileContents);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}


