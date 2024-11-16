using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.LoginUser
{
    public class LoginUserQueryResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
}
