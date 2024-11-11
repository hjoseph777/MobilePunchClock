using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PunchClock.Application.Services
{
    public interface ITokenService

    {
        string GenerateRefreshToken();
        string GenerateAccessToken(IEnumerable<Claim> claim);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string refreshToken);
        string ValidateJwtToken(string token);
    }
}
