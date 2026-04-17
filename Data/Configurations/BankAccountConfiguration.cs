using EventHorizon_API.Models.BankAccounts;
using EventHorizon_API.Models.Owners;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHorizon_API.Data.Configurations
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> bankAccount)
        {
            bankAccount.ToTable("bank_accounts");

            // Configuração TPH: bank_accounts emgloba os registros de business, checking e saving
            // A chave primária de Company é a mesma de Owner (relação 1:1)

            bankAccount.HasKey(ba => ba.Id);

            bankAccount.HasDiscriminator(ba => ba.Category);
                
            bankAccount.Property(ba => ba.Category)
                .HasConversion<String>()
                .HasMaxLength(8)
                .IsRequired();

            bankAccount.Property(ba => ba.Balance)
                .HasPrecision(15, 2)
                .HasDefaultValue(0)
                .IsRequired();

            bankAccount.Property(ba => ba.LoanLimit)
                .HasPrecision(15, 2)
                .IsRequired();

            bankAccount.Property(ba => ba.LoanDebt)
                .HasPrecision(15, 2)
                .HasDefaultValue(0)
                .IsRequired();

            bankAccount.Ignore(ba => ba.WithdrawalTax);
        }
    }
}
