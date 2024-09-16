using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Repositories
{
    public class TransactionTypeRepository
    {
        private FinancialTrackerContext ctx;
        public TransactionTypeRepository(FinancialTrackerContext ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<TransactionType> GetAll()
        {
            return ctx.TransactionTypes.ToList();
        }
        public TransactionType Get(int id)
        {
            return ctx.TransactionTypes.Find(id);
        }

        public int Add(TransactionType transactionType)
        {
            var obj = ctx.TransactionTypes.Add(transactionType);
            ctx.SaveChanges();
            return obj.Entity.Id_type;
        }
        public void Update(int id, TransactionType updTransactionType)
        {
            var transactiontypes = ctx.TransactionTypes.Find(id);

            if (transactiontypes.Title_type != updTransactionType.Title_type)
            {
                transactiontypes.Title_type = updTransactionType.Title_type;
                ctx.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            ctx.TransactionTypes.Remove(ctx.TransactionTypes.Find(id));
            ctx.SaveChanges();
        }
    }
}
