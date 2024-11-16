using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Token
{
    public interface ITokenHandler
    {
        DTOS.Token CreateAccessToken(int minute);
    }
}
