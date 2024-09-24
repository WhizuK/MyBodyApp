using MyBody.Domain;


namespace MyBody.Application.Services.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(Guid id);
        Task<User> Delete(User user);
    }
}
