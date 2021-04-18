using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TreinaWebMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //sliTamanhoTexto.ValueChanged += sliTamanhoTexto_ValueChanged;
            //sliRotacaoTexto.ValueChanged += sliRotacaoTexto_ValueChanged;
        }

        private void btnNavegarOutraPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OutraPagina());
        }

        //private void sliRotacaoTexto_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    lblTexto.Rotation = sliRotacaoTexto.Value;
        //    lblRotacaoTexto.Text = $"{sliRotacaoTexto.Value}°";
        //}

        //private void sliTamanhoTexto_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    lblTexto.Scale = sliTamanhoTexto.Value;
        //    lblTamanhoTexto.Text = $"x{sliTamanhoTexto.Value}";
        //}

        ////vai ser executada depois que terminar de mostrar a interface pro usuário
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //sliTamanhoTexto.Value = 1;
        //    sliRotacaoTexto.Value = 0;
        //    //lblTamanhoTexto.Text = "x1";
        //    lblRotacaoTexto.Text = "0°";

        //    //lblTexto.Scale = 1;
        //    lblTexto.Rotation = 0;
        //}
    }
}
