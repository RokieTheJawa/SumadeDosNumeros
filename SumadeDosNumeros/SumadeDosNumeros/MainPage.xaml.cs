using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumadeDosNumeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(valor1.Text);
                float b = float.Parse(valor2.Text);
                float c = a + b;
                string v = a + "+" + b + "=" + c;
                resultado.Text = v;
            }
            catch (Exception)
            {

                resultado.Text="Datos Inválidos";
            }
        }
    }
}
