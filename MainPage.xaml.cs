using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Corona
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
  
        public MainPage()
        {
            InitializeComponent();

            GetCases();
        }
        private async void GetCases()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("https://corona.lmao.ninja/all");

            // var cCases = JsonConvert.DeserializeObject<List<Cases>>(response);
            JsonClass obj = JsonConvert.DeserializeObject<JsonClass>(json);
            MessageType messageType = obj.Message;
            CasesListView.ItemsSource = Items;
        
        
        }
    }
}
