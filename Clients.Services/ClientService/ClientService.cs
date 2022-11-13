using System.Collections.Generic;
using System.Linq;
using Clients.Repositories.ClientRepository.Interfaces;
using Clients.Services.ClientService.Dto;
using Clients.Services.ClientService.Interfaces;

namespace Clients.Services.ClientService
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public List<ClientDto> GetAll()
        {
            var clients = clientRepository.GetAll();
            return clients.Select(x => x.EntityToDto()).ToList();
        }

        public void Add(CreateClientDto client)
        {
            clientRepository.Add(client.DtoToEntity());
        }
    }
}