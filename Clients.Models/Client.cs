using System;
using System.Collections.Generic;

namespace Clients.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Address> Adressess { get; set; }
    }
}