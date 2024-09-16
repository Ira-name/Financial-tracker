using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace FinancialTracker.Core.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_user { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        // Зв'язок один до багатьох: Користувач може мати багато транзакцій
        public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public override string ToString()
        {
            return $"{Name}-{Email}";
        }
    }
}
