using System.Collections.Generic;
using Clients.Models;

namespace Clients.Repositories.ClientRepository.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        void Add(Client client);
        void AddRange(List<Client> clients);
    }
}