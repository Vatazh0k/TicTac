using System;
using System.Linq;
using System.Net.Http;
using TicTac.Infrastructure.Extentions;

namespace TicTac.ConsoleApp
{
    class Program
    {
        static string path = "https://localhost:44376/GameConnection";

        static string[,] field1 = new string[3, 3]
            {
               { "X", "x", "X" },
               { "O", "O", "X" },
               { "O", "O", "" } 
            };


        static string[,] field2 = new string[3, 3]
            {
               { "X", "o", "X" },
               { "O", "O", "o" },
               { "O", "O", "X" }
            };


        static string[,] field3 = new string[3, 3]
           {
               { "X", "o", "" },
               { "O", "", "o" },
               { "", "O", "X" }
           };


        static string[,] field4 = new string[3, 3]
           {
               { "X", "o", "X" },
               { "x", "x", "o" },
               { "x", "O", "X" }
           };


        static string[,] field5 = new string[3, 3]
           {
               { "X", "x", "o" },
               { "O", "O", "o" },
               { "O", "O", "X" }
           };



        static string[,] field6 = new string[3, 3]
           {
               { "X", "o", "X" },
               { "O", "x", "o" },
               { "x", "O", "X" }
           };




        static string[,] field7 = new string[3, 3]
           {
               { "X", "o", "X" },
               { "x", "O", "o" },
               { "O", "x", "X" }
           };
        static void Main(string[] args)
        {
            //Connect();

            bool a = field1.HasEmptyCell();//t t f t t t f
            a = field2.HasEmptyCell();
            a = field3.HasEmptyCell();
            a = field4.HasEmptyCell(); 
            a = field5.HasEmptyCell();
            a = field6.HasEmptyCell();
            a = field7.HasEmptyCell();

        }


        private static void Connect()
        {
            var content = new HttpRequestMessage(HttpMethod.Get, $"{path}/CreateGame");

            var httpClient = new HttpClient();

            var request = httpClient.SendAsync(content);

            var response = request.Result;

            var responseContent = response.Content.ReadAsStringAsync();

            var result = responseContent.Result.ToString();
        }
    }
}
