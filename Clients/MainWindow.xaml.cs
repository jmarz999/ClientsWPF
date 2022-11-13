using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Clients.Services.ClientService.Dto;
using Clients.Services.ClientService.Interfaces;

namespace Clients
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IClientService clientService;

        public MainWindow(IClientService clientService)
        {
            InitializeComponent();
            this.clientService = clientService;
            GetClients();
            SetFormModel();
        }

        private void SetFormModel()
        {
            var client = new ClientDto();
            Binding myBinding = new Binding();
            myBinding.Source = client;
            myBinding.Mode = BindingMode.TwoWay;
        }

        public void GetClients()
        {
            var clients = clientService.GetAll();
            ClientList.ItemsSource = clients;
        }
    }
}