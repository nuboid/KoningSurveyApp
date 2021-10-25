using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using IO.Swagger.Model;
using Newtonsoft.Json;
namespace TestCallELOOMI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AuthResponse authResponse;

            using (var client = new HttpClient())
            {
                using (var multipartFormDataContent = new MultipartFormDataContent())
                {
                    var values = new[]
                    {
                        new KeyValuePair<string, string>("client_id", "353"),
                        new KeyValuePair<string, string>("client_secret", "yjUC7hngtlKJ7K2XG0CNaVfr7z7KAsOzs3907f13"),
                        new KeyValuePair<string, string>("grant_type", "client_credentials")
                    };

                    foreach (var keyValuePair in values)
                    {
                        multipartFormDataContent.Add(new StringContent(keyValuePair.Value),
                            String.Format("\"{0}\"", keyValuePair.Key));
                    }


                    var requestUri = "https://api.eloomi.com/oauth/token";
                    var result = await client.PostAsync(requestUri, multipartFormDataContent);
                    var json = await result.Content.ReadAsStringAsync();

                    authResponse = JsonConvert.DeserializeObject<AuthResponse>(json);

                    Console.WriteLine(authResponse.access_token);



                  


                    var request2Uri = "https://api.eloomi.com/v3/users?per_page=5&page=2";

                    client.DefaultRequestHeaders.Add("ClientId", "353");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authResponse.access_token);
                    var result2 = await client.GetAsync(request2Uri);
                    var json2 = await result2.Content.ReadAsStringAsync();
                    //Console.WriteLine(json2);

                    var data = JsonConvert.DeserializeObject<UsersSuccess>(json2);

                    foreach (var rec in data.Data)
                    {
                        Console.WriteLine(rec.LastName);
                    }
                }
            }

           
            Console.ReadKey();

        }
    }
}
