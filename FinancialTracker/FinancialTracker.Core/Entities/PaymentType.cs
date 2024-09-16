using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Core.Entities
{
    public class PaymentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_paymentType { get; set; }
        public string Payment_method { get; set; }
        // Зв'язок один до багатьох: Тип оплати може мати багато транзакцій
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public override string ToString()
        {
            return Payment_method;
        }
    }
}
