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
    public partial class Convertiddor2 : ContentPage
    {
        public Convertiddor2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Validamos la informacion y hacemos los calculos correspondientes
            if (double.TryParse(Cm.Text, out double cm))
            {
                double meters = cm / 100;
                DisplayAlert("Resultado", $"{cm} cm es igual a {meters} metros", "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese un valor válido en cm", "OK");
            }



        }
    }
}