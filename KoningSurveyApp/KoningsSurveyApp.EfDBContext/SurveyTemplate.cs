using System;
using System.Collections.Generic;
using System.Text;

namespace KoningsSurveyApp.EfDBContext
{
    public class SurveyTemplate
    {
        public string Id { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string SupplierNumber { get; set; }
        public List<SurveyGroup> SurveyGroups { get; set; }
        public string AnotherField { get; set; }
    }

    public class SurveyGroup
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<SurveyQuestion> Questions { get; set; }
    }

    public class SurveyQuestion
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public SurveyQuestionEnum SurveyQuestionType { get; set; }
    }

    public enum SurveyQuestionEnum
    {
        YesNoQuestion,
        YesNoNotApplicableQuestion,
        TakePhoto
    }
}
