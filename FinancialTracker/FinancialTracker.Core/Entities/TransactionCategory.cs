using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Core.Entities
{
    public class TransactionCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_category { get; set; }
        public string Title_categories { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public override string ToString()
        {
            return Title_categories;
        }
    }
}
