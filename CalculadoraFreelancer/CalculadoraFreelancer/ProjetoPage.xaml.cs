using CalculadoraFreelancer.Models;
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