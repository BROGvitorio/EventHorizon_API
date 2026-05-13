using EventHorizon_API.DTOs;
using EventHorizon_API.Models;
using EventHorizon_API.Repositories;

namespace EventHorizon_API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> ListAll() =>
            await _repository.ListAll();

        public async Task Create(UserDTO userDTO)
        {
            var newUser = new User
            {
                Email = userDTO.Email,
                LoginPassword = userDTO.LoginPassword
            };

            await _repository.Create(newUser);
        }

        public async Task Delete(String userEmail) {
            User user = await _repository.GetByEmail(userEmail);

            if(user != null) await _repository.Delete(user);
            else throw new Exception("Usuário não encontrado");
        }

        public async Task<UserDTO> GetByEmail(String userEmail)
        {
            User user = await _repository.GetByEmail(userEmail);

            if (user != null)
            {
                UserDTO userDTO = new UserDTO
                {
                    Email = user.Email,
                    LoginPassword = user.LoginPassword
                };
                return userDTO;
            }
                
            else throw new Exception("Usuário não encontrado");
        }
    }
}
