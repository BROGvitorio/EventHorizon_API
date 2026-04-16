namespace EventHorizon_API.Models.BankAccounts
{
    public class Checking : BankAccount
    {
        public Checking (int ownerId) : base (ownerId)
        {
            OwnerId = ownerId;
            WithdrawalTax = 00.5m;
            Category = AccountCategory.checking;
            // Cálculo do limite de empréstimo MI * 0.3
        }
    }
}
