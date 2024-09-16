using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Core.Entities
{
    public class TransactionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_type { get; set; }
        public string Title_type { get; set; }
        // Зв'язок один до багатьох: Тип транзакції може мати багато транзакцій
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public override string ToString()
        {
            return Title_type;
        }
    }
}
