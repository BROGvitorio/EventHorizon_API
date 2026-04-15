using EventHorizon_API.Models.Owners;

namespace EventHorizon_API.Models.BankAccounts
{
    public class BankAccount
    {
        public int Id { get; protected set; }
        public string Category { get; protected set; }
        public int OwnerId { get; protected set; }
    }
}
