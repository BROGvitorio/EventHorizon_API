using EventHorizon_API.Models.Owners;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHorizon_API.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string LoginPassword { get; private set; }

        public ICollection<Owner> Profiles { get; private set; }
    }
}
