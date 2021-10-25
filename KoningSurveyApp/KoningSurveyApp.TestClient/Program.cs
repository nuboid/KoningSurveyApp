using KoningSurveyApp.Contracts;
using Refit;
using System;
using System.Threading.Tasks;

namespace KoningSurveyApp.TestClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = RestService.For<ISurveyController>("https://localhost:5001/Survey");

            var template = await client.GetSurveyTemplate("1");

            foreach (var g in template.SurveyGroups)
            {
                foreach (var q in g.Questions)
                {
                    Console.WriteLine(q.Description);
                    switch (q.SurveyQuestionType)
                    {
                        case Contracts.DTOs.SurveyQuestionEnum.YesNoQuestion:
                            break;
                        case Contracts.DTOs.SurveyQuestionEnum.YesNoNotApplicableQuestion:
                            break;
                        case Contracts.DTOs.SurveyQuestionEnum.TakePhoto:
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
