using System.ComponentModel.DataAnnotations;

namespace EventHorizon_API.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "O campo de email não pode estar nulo!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de senha não pode estar nulo!")]
        public string LoginPassword { get; set; }
    }
}
