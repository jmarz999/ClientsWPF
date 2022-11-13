using System;
using System.Collections.Generic;
using System.ComponentModel;
using Clients.Models;

namespace Clients.Services.ClientService.Dto
{
    public class CreateClientDto
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<AddressDto> Addressess { get; set; }
    }
}
