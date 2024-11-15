using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using ManagementSystem.Persitence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Persitence.Repositories.Users
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(ManagementSystemDbContext context) : base(context)
        {
        }
    }
}
