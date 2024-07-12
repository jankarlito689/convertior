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
    public partial class IMC : ContentPage
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura, peso, imc;
            string resultado = "";

            // Validar y convertir las entradas
            if (double.TryParse(Altura.Text, out altura) && double.TryParse(Peso.Text, out peso))
            {
                // Convertir altura a metros
                altura = altura / 100;

                // Calcular el IMC
                imc = peso / (altura * altura);

                // Mostrar el resultado con dos decimales
                Imc.Text = imc.ToString("F2");

                //implementar si falla 
                //if (imc < 18)
                //{
                //    DisplayAlert("Modifica el peso", "ejemplo si tienes que ingresa un peso de 70kg en la app tendrias que ingresar 700000kg", "Gracias!!!");
                //}
                //else
                // Determinar la categoría de peso basada en el IMC calculado
                if (imc < 18.5)
                {
                    resultado = "Hay que comer mas¡¡¡";
                }
                else if (imc >= 18.5 && imc <= 25)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 30)
                {
                    resultado = "Tienes sobrepeso, bro¡¡";
                }
                else if (imc > 30)
                {
                    resultado = "¡Estás gordito!";
                }

                if (!string.IsNullOrEmpty(resultado))
                {
                    DisplayAlert("Resultado", resultado, "Okey");
                }
            }
            else
            {
                // Mostrar un mensaje de error si la entrada no es válida
                DisplayAlert("Información incorrecta", "Favor de llenar los campos correspondientes con información correcta", "Entendido");
            }


        }
    }
}