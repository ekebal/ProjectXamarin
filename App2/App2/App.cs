using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using CloudKit;

using System.Reflection.Emit;

using System.Threading.Tasks;
using Xamarin.Forms;



namespace App2
{
    public class App : Application
    {
        ListView lv = new ListView();
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "App2",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "teste dava",
                            lv
                    
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
            Iniciar();
        }

        private async void Iniciar()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://46.101.40.23:1337/contactType/");
                var resp = await client.GetAsync(client.BaseAddress);
                if (resp.IsSuccessStatusCode)
                {
                    var respStr = resp.Content.ReadAsStringAsync();
                    var l = JsonConvert.DeserializeObject<List<UserInformations>>(respStr.Result);
                    System.Diagnostics.Debug.WriteLine(respStr.Result);
                    lv.ItemsSource = l;
                }
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}

    
    
