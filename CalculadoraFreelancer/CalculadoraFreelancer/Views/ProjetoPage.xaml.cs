using CalculadoraFreelancer.ViewModels;
using CommonServiceLocator;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjetoPage : ContentPage
    {
        public ProjetoPage()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<ProjetoPageViewModel>();
            BindingContext = viewModel;
        }

    }
}