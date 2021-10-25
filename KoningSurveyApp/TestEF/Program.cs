using KoningsSurveyApp.EfDBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Newtonsoft.Json;
namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db =new SurveyContext())
            {
                //var rec = new SurveyTemplate
                //{
                //    Id = "id2",
                //    AnotherField = "AAAAAAAAAAAAAAA"
                //};
                //rec.SurveyGroups = new System.Collections.Generic.List<SurveyGroup>
                //{
                //    new SurveyGroup
                //    {
                //        Id="g1",
                //        Title="TEST1"
                //    },
                //    new SurveyGroup
                //    {
                //        Id="g2",
                //        Title="TEST2"
                //    }
                //};
                //db.Add(rec);
                //db.SaveChanges();
                var list = db.SurveyTemplates
                    .Include(c => c.SurveyGroups);
                    
                    
                foreach (var item in list)
                {
                    Console.WriteLine(item.AnotherField);
                    if (item.SurveyGroups != null)
                    {
                        foreach (var g in item.SurveyGroups)
                        {
                            Console.WriteLine(" " + g.Title);
                        }
                    }
                }
            }
        }
    }
}
