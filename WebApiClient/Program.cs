// See https://aka.ms/new-console-template for more information
namespace WebApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("press any key cont.....");
            Console.ReadLine();

            using(HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("http://localhost:5038/values");
                response.EnsureSuccessStatusCode();
                if(response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"response error code : {response.StatusCode}");
                }
            }
            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}
