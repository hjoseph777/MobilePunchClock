using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunchClock.Application.Services
{
    public interface IAccountSevice
    {
        Task CreateSuperAdminAccount();
    }
}
