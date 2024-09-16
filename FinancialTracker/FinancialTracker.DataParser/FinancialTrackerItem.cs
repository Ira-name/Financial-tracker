using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialTracker.DataParser
{
    record FinancialTrackerItem(
        string name,
        string email,
        string password,
        double amout,
        string description,
        DateTime date,
        string payment_method,
        string title_currency,
        string title_categories,
        string title_type);
}
