using System;
using System.Collections.Generic;
using System.Text;

namespace KoningSurveyApp.Contracts.DTOs
{
    public class SurveyAnswers
    {
        public List<AnswerItem> Answers { get; set; }
    }

    public class AnswerItem
    {
        public string QuestionId { get; set; }

        public string Answer { get; set; }
    }
}
