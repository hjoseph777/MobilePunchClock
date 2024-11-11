using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchClock.Database.Domain
{
    public class Client 
    {

        public Guid Id { get; set; }
        public string Address { get; set; }


        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public string WebAddress { get; set; }

        public virtual List<ClientUserMapping> ClientUserMapping { get; set; }



    }
}
