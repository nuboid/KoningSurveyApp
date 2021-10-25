using KoningSurveyApp.Contracts;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KoningsSurveyApp.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var client = RestService.For<ISurveyController>("http://localhost:54856/Survey");

            var template = await client.GetSurveyTemplate("1");

            foreach (var g in template.SurveyGroups)
            {
                foreach (var q in g.Questions)
                {
                    _sl.Children.Add(new Label
                    {
                        Text = q.Description
                    });
                   
                }
            }
        }
    }
}
