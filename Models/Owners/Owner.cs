using EventHorizon_API.Models.BankAccounts;

namespace EventHorizon_API.Models.Owners
{
    public class Owner
    {
        public enum OwnerType
        {
            person = 0,
            company = 1
        }

        protected OwnerType _type;
        public int Id { get; private set; }
        public int UserId { get; private set; }

        public ICollection<BankAccount> BankAccounts { get; protected set; }

        public OwnerType Type {
            get { return _type; }
            protected set { _type = value; }
        }
    }
}
