using System;
using System.Collections.Generic;
using System.Text;

namespace KoningSurveyApp.Contracts.DTOs
{
    public class SurveyTemplate
    {
        public string DocumentNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierName { get; set; }
        public List<SurveyGroup> SurveyGroups { get; set; }
    }

    public class SurveyGroup
    {
        public string Title { get; set; }
        public List<SurveyQuestion> Questions { get; set; }
    }

    public class SurveyQuestion
    {
        public string ID { get; set; }
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
