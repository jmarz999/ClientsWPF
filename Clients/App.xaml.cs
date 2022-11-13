using System.Windows;
using Clients.Models.EntityFramework;
using Clients.Repositories.ClientRepository;
using Clients.Repositories.ClientRepository.Interfaces;
using Clients.Services.ClientService;
using Clients.Services.ClientService.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Clients
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Clients;Trusted_Connection=True;");
            });

            services.AddSingleton<MainWindow>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientService, ClientService>();
        }

        public void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWidow = serviceProvider.GetService<MainWindow>();
            mainWidow.Show();
            //preku ovoj metod se launchnuva main window
        }
    }
}