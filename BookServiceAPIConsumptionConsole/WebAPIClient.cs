using BookServiceAPIConsumptionConsole.BookClass;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BookServiceAPIConsumptionConsole
{
    public class WebAPIClient
    {
        private static HttpClient client;
        private static string baseURL;

        public WebAPIClient(string url)
        {
            client = new HttpClient();
            baseURL = url;
        }

        public async void Create(BookDetail bookDetail)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")); //ACCEPT header

                var completeURL = string.Empty;

                completeURL = baseURL + "/api/book/create";

                var queryString = new StringContent(JsonConvert.SerializeObject(bookDetail), Encoding.UTF8,
                    "application/json");

                var taskResponse = client.PostAsync(completeURL, queryString).Result;
                if (taskResponse.IsSuccessStatusCode)
                {
                    var jsonString = await taskResponse.Content.ReadAsStringAsync();

                    //Newly Created ID 
                    Console.WriteLine("Book Created and ID is : " + jsonString);
                }
            }
        }

        public async void Update(BookDetail bookDetail, int bookid)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")); //ACCEPT header

                var completeURL = string.Empty;

                completeURL = baseURL + "/api/book/" + bookid + "/update";

                var queryString = new StringContent(JsonConvert.SerializeObject(bookDetail), Encoding.UTF8,
                    "application/json");

                var taskResponse = client.PutAsync(completeURL, queryString).Result;
                if (taskResponse.IsSuccessStatusCode)
                {
                    var jsonString = await taskResponse.Content.ReadAsStringAsync();

                    //Returing the updated Details
                    Console.WriteLine("Book Updated  : " + jsonString);
                }
            }
        }
    }
}