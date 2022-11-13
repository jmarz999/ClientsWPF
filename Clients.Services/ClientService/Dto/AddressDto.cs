using Clients.Models;

namespace Clients.Services.ClientService.Dto
{
    public class AddressDto
    {
        public string Name { get; set; }
        public AddressType Type { get; set; }
        public int ClientId { get; set; }
    }
}