using System;
using System.Collections.Generic;
using System.Text;
using Clients.Models;

namespace Clients.Services.ClientService.Dto
{
    public class ClientDto : CreateClientDto
    {
        public int Id { get; set; }
    }
}
