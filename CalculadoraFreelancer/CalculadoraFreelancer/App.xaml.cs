using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Infra.Data.Repository;
using CalculadoraFreelancer.Services;
using CalculadoraFreelancer.Services.Interfaces;
using CalculadoraFreelancer.Views;
using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;

namespace CalculadoraFreelancer
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<IProjetoRepository, ProjetoRepository>();
            unityContainer.RegisterType<IProfissionalRepository, ProfissionalRepository>();

            unityContainer.RegisterType<IProjetoService, ProjetoService>();
            unityContainer.RegisterType<IProfissionalService, ProfissionalService>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            MainPage = new NavigationPage(new HomePage());  
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
