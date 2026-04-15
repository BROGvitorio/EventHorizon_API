using EventHorizon_API.Models;
using EventHorizon_API.Models.Owners;
using Microsoft.EntityFrameworkCore;

namespace EventHorizon_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(user =>
            {
                user.ToTable("Users");

                user.HasKey(u => u.Id);

                user.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(255);
                user.HasIndex(u => u.Email)
                    .IsUnique();

                user.Property(u => u.LoginPassword)
                    .IsRequired()
                    .HasMaxLength(255);

                user.HasMany(u => u.Profiles)
                    .WithOne()
                    .HasForeignKey(o => o.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Owner>(owner =>
            {
                owner.ToTable("Owners");

                owner.HasKey(o => o.Id);

                owner.Property(o => o.Type)
                    .HasField("_type")
                    .HasMaxLength(7)
                    .HasConversion<String>();
            });

            modelBuilder.Entity<Person>(person =>
            {
                person.ToTable("People");

                // Configuração TPT: Person herda de Owner
                // A chave primária de Person é a mesma de Owner (relação 1:1)

                person.Property(p => p.Cpf)
                    .HasMaxLength(11)
                    .IsRequired();
                person.HasIndex(p => p.Cpf)
                    .IsUnique();

                person.Property(p => p.FullName)
                    .HasMaxLength(255)
                    .IsRequired();

                person.Property(p => p.BirthDate)
                    .HasMaxLength(8)
                    .IsRequired();

                person.Property(p => p.Salary)
                    .HasPrecision(15, 2);
            });

            modelBuilder.Entity<Company>(company =>
            {
                company.ToTable("Companies");

                // Configuração TPT: Company herda de Owner
                // A chave primária de Company é a mesma de Owner (relação 1:1)

                company.Property(c => c.Cnpj)
                    .HasMaxLength(14)
                    .IsRequired();
                company.HasIndex(c => c.Cnpj)
                    .IsUnique();

                company.Property(c => c.FantasyName)
                    .HasMaxLength(255)
                    .IsRequired();

                company.Property(c => c.MonthlyIncome)
                    .HasPrecision(15, 2)
                    .IsRequired();
            });
        }
    }
}
