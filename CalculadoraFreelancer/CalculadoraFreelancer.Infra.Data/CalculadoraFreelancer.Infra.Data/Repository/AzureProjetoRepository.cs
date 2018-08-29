using CalculadoraFreelancer.Domain.Projeto;
using Microsoft.WindowsAzure.MobileServices;

namespace CalculadoraFreelancer.Infra.Data.Repository
{
    public class AzureProjetoRepository
    {
        private IMobileServiceClient Client;
        private IMobileServiceTable<Projeto> Table;

        public AzureProjetoRepository()
        {
            string MyAppServiceURL = "https://calculadorafreelancer01.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            Table = Client.GetTable<Projeto>();
        }

        public async void Insert(Projeto projeto)
        {
            await Table.InsertAsync(projeto);
        }
    }
}
