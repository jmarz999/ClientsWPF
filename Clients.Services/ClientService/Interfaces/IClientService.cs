using System.Collections.Generic;
using Clients.Services.ClientService.Dto;

namespace Clients.Services.ClientService.Interfaces
{
    public interface IClientService
    {
        List<ClientDto> GetAll();
        void Add(CreateClientDto client);
    }
}