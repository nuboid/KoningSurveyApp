using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestCallELOOMI
{
    class Program
    {
        static async Task Main(string[] args)
        {


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
                    var x = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(x);

                }
            }

           
            Console.ReadKey();

        }
    }
}
