using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel3.Views
{
    public partial class ContratacaoHospedagemxaml : ContentPage
    {
        public ContratacaoHospedagemxaml()
        {
            InitializeComponent();
        }

       
        private async void Sobre33_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new Sobre33());
        }
    }
}
