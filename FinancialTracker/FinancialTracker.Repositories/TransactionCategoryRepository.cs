using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Repositories
{
    public class TransactionCategoryRepository
    {
        private FinancialTrackerContext ctx;
        public TransactionCategoryRepository(FinancialTrackerContext ctx) 
        { 
            this.ctx = ctx;
        }
        public IEnumerable<TransactionCategory> GetAll()
        {
            return ctx.TransactionCategories.ToList();
        }
        public TransactionCategory Get(int id)
        {
            return ctx.TransactionCategories.Find(id);
        }

        public int Add(TransactionCategory transactionCategory)
        {
            var obj = ctx.TransactionCategories.Add(transactionCategory);
            ctx.SaveChanges();
            return obj.Entity.Id_category;
        }
        public void Update(int id, TransactionCategory updTransactionCategory)
        {
            var transactioncategory = ctx.TransactionCategories.Find(id);

            if (transactioncategory.Title_categories != updTransactionCategory.Title_categories)
            {
                transactioncategory.Title_categories = updTransactionCategory.Title_categories;
                ctx.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            ctx.TransactionCategories.Remove(ctx.TransactionCategories.Find(id));
            ctx.SaveChanges();
        }
    }
}
