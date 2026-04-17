namespace EventHorizon_API.Models.Owners
{
    public class Company : Owner
    {
        public string Cnpj { get; private set; }
        public string FantasyName { get; private set; }
        public decimal MonthlyIncome { get; private set; }

        public Company(int userId, OwnerType ownerType) : base(userId, OwnerType.company) { }
    }
}
