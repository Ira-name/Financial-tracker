using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Core.Entities
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_transaction { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        // public TransactionCategory TransactionCategory { get; set; }
        // public TransactionType TransactionType { get; set; }
        //public PaymentType PaymentType { get; set; }
        //
        //


        /* public override string ToString()
         {
             return $"{Date} - {Description} - {TransactionType?.Title_type} - {TransactionCategory?.Title_categories} - {PaymentType?.Payment_method} - {Amount} - {Currency?.Title_currency} ";
         }*/
        public  int CurrencyId { get; set; }
    [ForeignKey("CurrencyId")]
    public Currency Currency { get; set; }

    public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int TransactionCategoryId { get; set; }
        [ForeignKey("TransactionCategoryId")]
        public TransactionCategory TransactionCategory { get; set; }

        public int TransactionTypeId { get; set; }
        [ForeignKey("TransactionTypeId")]
        public TransactionType TransactionType { get; set; }

        public int PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
        public override string ToString()
        {
            return $"{Date} - {Description} - {TransactionType?.Title_type} - {TransactionCategory?.Title_categories} - {PaymentType?.Payment_method} - {Amount} - {Currency?.Title_currency}";
        }
    }
}
