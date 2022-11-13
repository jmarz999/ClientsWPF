using System.Collections.Generic;
using System.Linq;
using Clients.Models;
using Clients.Models.EntityFramework;
using Clients.Repositories.ClientRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clients.Repositories.ClientRepository
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext context;

        public ClientRepository(AppDbContext context)
        {
            this.context = context;
        }

        public List<Client> GetAll()
        {
            return context.Clients.Include(x => x.Adressess).ToList();
        }

        public void Add(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public void AddRange(List<Client> clients)
        {
            context.Clients.AddRange(clients);
            context.SaveChanges();
        }
    }
}
