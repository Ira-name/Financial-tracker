using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Repositories
{
    public class TransactionRepository
    {
        private FinancialTrackerContext ctx;
        public TransactionRepository(FinancialTrackerContext ctx) { this.ctx = ctx; }
        public IEnumerable<Transaction> GetAll()
        {
            return ctx.Transactions.ToList();
        }
        public Transaction Get(int id)
        {
            return ctx.Transactions.Find(id);
        }

        public int Add(Transaction transaction)
        {
            var obj = ctx.Transactions.Add(transaction);
            ctx.SaveChanges();
            return obj.Entity.Id_transaction;
        }
        public void Update(int Id, Transaction updTransaction)
        {
            var transactions = ctx.Transactions.Find(Id);
            if (transactions.Amount != updTransaction.Amount || transactions.Description != updTransaction.Description || transactions.Date != updTransaction.Date)
            {
                transactions.Amount = updTransaction.Amount;
                transactions.Description = updTransaction.Description;
                transactions.Date = updTransaction.Date;

                ctx.SaveChanges();
            }

        }
        public void Delete(int id)
        {
            ctx.Transactions.Remove(ctx.Transactions.Find(id));
            ctx.SaveChanges();
        }

        public void DeleteTransactionById(int transactionId)
        {
            var transaction = ctx.Transactions.Find(transactionId);

            if (transaction != null)
            {
                ctx.Transactions.Remove(transaction);
                ctx.SaveChanges();
            }
        }
        public IEnumerable<Transaction> GetTransactionsByUserId(int userId)
{
            return ctx.Transactions.Where(t => t.User.Id_user == userId).ToList();
        }
        public IEnumerable<Transaction> GetTransactionsWithDetailsByUserId(int userId)
        {
            return ctx.Transactions
                .Include(t => t.TransactionCategory)
                .Include(t => t.TransactionType)
                .Include(t => t.PaymentType)
                .Include(t => t.Currency)
                .Where(t => t.User.Id_user == userId)
                .ToList();
        }

        public TransactionCategory GetCategoryByName(string categoryName)
        {
            return ctx.TransactionCategories.FirstOrDefault(c => c.Title_categories == categoryName);
        }

        public TransactionType GetTransactionTypeByName(string transactionTypeName)
        {
            return ctx.TransactionTypes.FirstOrDefault(t => t.Title_type == transactionTypeName);
        }

        public PaymentType GetPaymentTypeByName(string paymentTypeName)
        {
            return ctx.PaymentTypes.FirstOrDefault(p => p.Payment_method == paymentTypeName);
        }

        public Currency GetCurrencyByName(string currencyName)
        {
            return ctx.Currencies.FirstOrDefault(c => c.Title_currency == currencyName);
        }
        public TransactionCategory GetSelectedTransactionCategory(object selectedItem)
        {
            if (selectedItem is TransactionCategory selectedCategory)
            {
                return selectedCategory;
            }
            return null;
        }

        public TransactionType GetSelectedTransactionType(object selectedItem)
        {
            if (selectedItem is TransactionType selectedType)
            {
                return selectedType;
            }
            return null;
        }

        public PaymentType GetSelectedPaymentType(object selectedItem)
        {
            if (selectedItem is PaymentType selectedPaymentType)
            {
                return selectedPaymentType;
            }
            return null;
        }

        public Currency GetSelectedCurrency(object selectedItem)
        {
            if (selectedItem is Currency selectedCurrency)
            {
                return selectedCurrency;
            }
            return null;
        }


     
    }
}

