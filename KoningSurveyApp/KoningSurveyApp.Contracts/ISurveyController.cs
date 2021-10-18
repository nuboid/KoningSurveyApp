using KoningSurveyApp.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;

namespace KoningSurveyApp.Contracts
{
    public interface ISurveyController
    {

        [Get("/GetSurveyTemplate")]
        Task<SurveyTemplate> GetSurveyTemplate(string poNumber);

        [Post("/PostAnswers")]
        Task PostAnswers(SurveyAnswers answers);
      
    }
}
