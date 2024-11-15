using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using ManagementSystem.Persitence.Contexts; 

namespace ManagementSystem.Persitence.Repositories.Users
{
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(ManagementSystemDbContext context) : base(context)
        {
        }
    }
}
