using PuchClock.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchClock.Database.Domain
{
    public class Employee : AppUser
    {
        public string VehicleNumber { get; set; }
    }
}
