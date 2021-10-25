using KoningSurveyApp.Contracts;
using KoningSurveyApp.Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoningsSurveyApp.APIHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurveyController : ControllerBase, ISurveyController
    {
        [HttpGet]
        [Route("GetSurveyTemplate")]
        public async Task<SurveyTemplate> GetSurveyTemplate(string poNumber)
        {
            return new SurveyTemplate
            {
                DateTime = DateTime.Now,
                DocumentNumber = "Doc111",
                SupplierName = "kjshdfkjshf",
                SupplierNumber = "jkshdkjds",
                SurveyGroups = new List<SurveyGroup>()
                {
                    new SurveyGroup
                    {
                        Title="Controle uitgevoerd door logistiek administratieve afdeling",
                        Questions = new List<SurveyQuestion>()
                        {
                            new SurveyQuestion
                            {
                                ID="Q1",
                                Title="Documenten aanwezig",
                                Description="CMR aanwezig en compleet",
                                SurveyQuestionType = SurveyQuestionEnum.YesNoQuestion
                            },
                            new SurveyQuestion
                            {
                                ID="Q2",
                                Title="Documenten aanwezig",
                                Description="Leverbon aanwezig en compleet",
                                SurveyQuestionType = SurveyQuestionEnum.YesNoQuestion
                            }
                        }

                    },
                    new SurveyGroup
                    {
                        Title="Controle uitgevoerd door heftrucker",
                        Questions = new List<SurveyQuestion>()
                        {
                            new SurveyQuestion
                            {
                                ID="Q3",
                                Title="Verzegeling",
                                Description="Zegelnummer komt overeen",
                                SurveyQuestionType = SurveyQuestionEnum.YesNoNotApplicableQuestion
                            }
                        }
                    }
                },


            };
        }

        [HttpPost]
        [Route("PostAnswers")]
        public async Task PostAnswers(SurveyAnswers answers)
        {

        }
    }
}
