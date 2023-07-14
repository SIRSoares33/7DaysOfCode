using RestSharp;

namespace _7DaysOfCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/pokemon/");
            RestRequest request = new RestRequest("", Method.Get);

            var response = client.Execute(request);

            Console.WriteLine(response.Content);
        }
    }
}