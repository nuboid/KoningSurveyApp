using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
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

                    //Begin Authenticate
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
                    //End Authenticate



                    //Begin List Users
                    var request2Uri = "https://api.eloomi.com/v3/users?per_page=5&page=2";

                    client.DefaultRequestHeaders.Add("ClientId", "353");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authResponse.access_token);
                    var result2 = await client.GetAsync(request2Uri);
                    var json2 = await result2.Content.ReadAsStringAsync();
                    
                    //Console.WriteLine(json2);
                    
                    var data = JsonConvert.DeserializeObject<UsersSuccess>(json2);

                    foreach (var rec in data.Data)
                    {
                        Console.WriteLine(rec.Id);
                        Console.WriteLine(rec.LastName);
                        Console.WriteLine(rec.Title);
                        Console.WriteLine("------------");
                        File.WriteAllText("user"+rec.Id+".txt", JsonConvert.SerializeObject(rec, Formatting.Indented));
                    }
                    //End list Users







                    //Update User 165
                    //var user165 = JsonConvert.DeserializeObject<User>(File.ReadAllText("User165.txt"));
                    var user165 = new User();
                    user165.Id = 165;
                    user165.Title = "test3";
                    var json3 = JsonConvert.SerializeObject(user165, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    Console.WriteLine(json3);
                    var userRequestContent = new StringContent(
                        json3,
                        Encoding.UTF8,
                        "application/json");
                    var request3Uri = "https://api.eloomi.com/v3/users/165";



                    ////var result3 = await client.SendAsync(msg);
                    var result3 = await client.PatchAsync(request3Uri, userRequestContent);
                    var json4 = await result3.Content.ReadAsStringAsync();

                }
            }

           
            Console.ReadKey();

        }
    }
}
