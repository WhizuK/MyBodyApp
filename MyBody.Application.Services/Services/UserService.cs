using Microsoft.EntityFrameworkCore;
using MyBody.Application.Services.Contracts;
using MyBody.Domain;


namespace MyBody.Application.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;


        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<User> Create(User user)
        {
            user.Id = Guid.NewGuid();
            var entity = await _repository.Create(user);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<User> Delete(User user)
        {
            var entity =  _repository.Delete(user);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<User> Delete(Guid id)
        {
            var entity = await _repository.Delete(id);
            await _unitOfWork.Commit();
            return entity;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<User> Update(User user)
        {
            var entity = _repository.Update(user);
            await _unitOfWork.Commit();
            return entity;
        }

        

    }
}
