using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Repositories
{
    public class PaymentTypeRepository
    {
        private FinancialTrackerContext ctx;
        public PaymentTypeRepository(FinancialTrackerContext ctx) { this.ctx = ctx; }
        public IEnumerable<PaymentType> GetAll()
        {
            return ctx.PaymentTypes.ToList();
        }
        public PaymentType Get(int id)
        {
            return ctx.PaymentTypes.Find(id);
        }

        public int Add(PaymentType paymentType)
        {
            var obj = ctx.PaymentTypes.Add(paymentType);
            ctx.SaveChanges();
            return obj.Entity.Id_paymentType;
        }
        public void Update(int id, PaymentType updPaymentType)
        {
            var paymentTypes = ctx.PaymentTypes.Find(id);

            if (paymentTypes.Payment_method != updPaymentType.Payment_method)
            {
                paymentTypes.Payment_method = updPaymentType.Payment_method;
                ctx.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            ctx.PaymentTypes.Remove(ctx.PaymentTypes.Find(id));
            ctx.SaveChanges();
        }
    }
}
