using CalculadoraFreelancer.Repository;
using CalculadoraFreelancer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraFreelancer
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