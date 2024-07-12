using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.Cal.IsPresented = false;
            await App.Cal.Detail.Navigation.PushAsync(new IMC());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Cal.IsPresented = false;
            await App.Cal.Detail.Navigation.PushAsync(new Convertidor());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Cal.IsPresented = false;
            await App.Cal.Detail.Navigation.PushAsync(new Convertiddor2());
        }
    }
}