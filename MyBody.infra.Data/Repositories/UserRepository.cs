using Microsoft.EntityFrameworkCore;
using MyBody.Application.Services.Contracts;
using MyBody.Domain;


namespace MyBody.infra.Data.Repositories
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) 
        {
            context.Users
                .Include(user => user.BodyMeasurements)
                .Include(user => user.BodyComposition)
                .ToList();
        }

    }
}
