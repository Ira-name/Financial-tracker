using FinancialTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Core.Context
{
    public class FinancialTrackerContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Transaction> Transactions => Set<Transaction>();
        public DbSet<TransactionCategory> TransactionCategories => Set<TransactionCategory>();
        public DbSet<TransactionType> TransactionTypes => Set<TransactionType>();
        public DbSet<PaymentType> PaymentTypes => Set<PaymentType>();
        public DbSet<Currency> Currencies => Set<Currency>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=FinancialTracker;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
