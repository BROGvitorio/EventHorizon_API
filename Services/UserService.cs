using EventHorizon_API.DTOs;
using EventHorizon_API.Models;
using EventHorizon_API.Repositories;

namespace EventHorizon_API.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> ListAll() =>
            await _repository.ListAll();

        public async Task Criar(UserDTO userDTO)
        {
            var user = new User
            {
                Email = userDTO.Email,
                LoginPassword = userDTO.LoginPassword
            };

            await _repository.Add(user);
        }
    }
}
