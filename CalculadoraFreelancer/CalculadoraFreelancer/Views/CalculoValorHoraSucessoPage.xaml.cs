using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculoValorHoraSucessoPage : ContentPage
    {
        public CalculoValorHoraSucessoPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopAsync();
        }
    }
}