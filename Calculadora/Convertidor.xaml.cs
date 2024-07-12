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
    public partial class Convertidor : ContentPage
    {
        public Convertidor()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double onzas, gramos;

            // Validar y convertir la entrada
            if (double.TryParse(Oz.Text, out onzas))
            {
                // Convertir onzas a kilogramos
                gramos = onzas * 28.3495;

                // Mostrar el resultado en un DisplayAlert
                DisplayAlert("Resultado", $"{onzas} onzas son {gramos:F2} gramos", "OK");
            }
            else
            {
                // Mostrar un mensaje de error si la entrada no es válida
                DisplayAlert("Error", "Por favor, introduce un valor numérico válido para las onzas.", "OK");
            }
        }
    }
}