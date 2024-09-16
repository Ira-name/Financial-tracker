using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;

namespace FinancialTracker.Repositories
{
    public class CurrencyRepository
    {
        private FinancialTrackerContext ctx;
        public CurrencyRepository(FinancialTrackerContext ctx) { this.ctx = ctx; }
        public IEnumerable<Currency> GetAll()
        {
            return ctx.Currencies.ToList();
        }
        public Currency Get(int id)
        {
            return ctx.Currencies.Find(id);
        }

        public int Add(Currency currency)
        {
            var obj = ctx.Currencies.Add(currency);
            ctx.SaveChanges();
            return obj.Entity.id_currency;
        }
        public void Update(int id, Currency updCurrency)
        {
            var currensys = ctx.Currencies.Find(id);

            if (currensys.Title_currency != updCurrency.Title_currency)
            {
                currensys.Title_currency = updCurrency.Title_currency;
                ctx.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            ctx.Currencies.Remove(ctx.Currencies.Find(id));
            ctx.SaveChanges();
        }
    }
}
