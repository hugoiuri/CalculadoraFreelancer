using CalculadoraFreelancer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculoValorHoraPage : ContentPage
    {
        public CalculoValorHoraPage()
        {
            InitializeComponent();
            var viewModel = new CalculoValorHoraPageViewModel();
            BindingContext = viewModel;
        }
    }
}