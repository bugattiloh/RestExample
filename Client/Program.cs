using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync("http://localhost:5000/Person/Get");
            Console.WriteLine(result);
        }
    }
}