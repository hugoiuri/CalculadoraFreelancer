using CalculadoraFreelancer.ViewModels;
using CommonServiceLocator;
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
            var viewModel = ServiceLocator.Current.GetInstance<CalculoValorHoraPageViewModel>();
            BindingContext = viewModel;
        }
    }
}