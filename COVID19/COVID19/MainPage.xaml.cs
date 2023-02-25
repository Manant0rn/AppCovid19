using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COVID19
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetDataCovid19();
        }

        private async void GetDataCovid19()
        {
            try
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync("https://static.easysunday.com/covid-19/getTodayCases.json?fbclid=IwAR0S3eSwPvoHQKpU9rROS6gulGXLA6y1k5Hyvx2RYt-NcDxQFh-nnydQASk");
                var datacovid = JsonConvert.DeserializeObject<Covid>(response);
                date.Text = $"อัปเดตข้อมูลล่าสุด {datacovid.UpdateDate}";
                cases.Text = $"{string.Format("{0:n0}", datacovid.cases)} คน";
                casestoday.Text = $"( + {string.Format("{0:n0}",datacovid.todayCases)} คน)";
                recovered.Text = $"{string.Format("{0:n0}", datacovid.recovered)} คน";
                recoveredtoday.Text = $"( + {string.Format("{0:n0}", datacovid.todayRecovered)} คน)";
                hospitalized.Text = $"{string.Format("{0:n0}", datacovid.Hospitalized)} คน";
                hospitalizedtoday.Text = $"( + {string.Format("{0:n0}", datacovid.NewHospitalized)} คน)";
                death.Text = $"{string.Format("{0:n0}", datacovid.deaths)} คน";
                deathtoday.Text = $"( + {string.Format("{0:n0}", datacovid.NewDeaths)} คน)";
                devby.Text = datacovid.DevBy;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
