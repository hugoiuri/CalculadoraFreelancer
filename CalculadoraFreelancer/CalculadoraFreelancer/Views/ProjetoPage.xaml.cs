using CalculadoraFreelancer.ViewModels;
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
            var viewModel = new ProjetoPageViewModel();
            BindingContext = viewModel;
        }

    }
}