using System;
using System.Net.Http;

namespace TicTac.ConsoleApp
{
    class Program
    {
        static string path = "https://localhost:44376/GameConnection";
        static void Main(string[] args)
        {
            var content = new HttpRequestMessage(HttpMethod.Get, $"{path}/CreateGame");

            var httpClient = new HttpClient();

            var request = httpClient.SendAsync(content);

            var response = request.Result;

            var responseContent = response.Content.ReadAsStringAsync();
                
            var result =  responseContent.Result.ToString();
        }
    }
}
