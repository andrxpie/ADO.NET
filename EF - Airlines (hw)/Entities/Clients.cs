using EF___Airlines__hw_.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsMale { get; set; }
        public int AccountId { get; set; }
        public CAccount Account { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}
