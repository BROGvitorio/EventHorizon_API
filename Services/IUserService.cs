using EventHorizon_API.DTOs;
using EventHorizon_API.Models.BankAccounts;

namespace EventHorizon_API.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> ListAll();
        Task Create(UserDTO userDTO);
    }
}
