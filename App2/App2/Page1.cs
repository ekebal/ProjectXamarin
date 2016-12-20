using CloudKit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public class Page1 : ContentPage
    {
        private ContentPage content;
        ListView lv = new ListView();
        public Page1()
        {
            var tbBuscar = new ToolbarItem();
            tbBuscar.Text = "Teste recuperation data ";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" },
                    lv
                }
            };


        }


    }
}

