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
        public Task<SurveyTemplate> GetSurveyTemplate(string poNumber)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("PostAnswers")]
        public Task PostAnswers(SurveyAnswers answers)
        {
            throw new NotImplementedException();
        }
    }
}
