using CsvHelper;
using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using FinancialTracker.DataParser;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

var dataPath = Path.Combine(Directory.GetCurrentDirectory(), "Data.csv");

IEnumerable<FinancialTrackerItem> records = null;

Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Application initialized!");


using (var reader = new StreamReader(dataPath))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    records = csv.GetRecords<FinancialTrackerItem>().ToList(); ;
}

foreach (var record in records.Take(10))
///foreach (var record in records)
{
  Console.WriteLine($"{record.name}-{record.email}-{record.password}-{record.amout}-{record.description}-{record.date}-{record.payment_method}-{record.title_currency}-{record.title_categories}-{record.title_type}");
}
Console.WriteLine(records.Count());
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Forbes data loaded!");


var context = new FinancialTrackerContext();

var currencys = records.Select(x => new { x.title_currency }).Distinct().ToList();
context.Currencies.AddRange(currencys.Select(x => new Currency { Title_currency = x.title_currency }));
context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Currency data loaded!");

var paymenttypes = records.Select(x => new { x.payment_method }).ToList();
context.PaymentTypes.AddRange(paymenttypes.Select(x => new PaymentType { Payment_method = x.payment_method }));
context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] PaymentType data loaded!");


var transactioncategories = records.Select(x => new { x.title_categories }).ToList();
context.TransactionCategories.AddRange(transactioncategories.Select(x => new TransactionCategory { Title_categories = x.title_categories }));
context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] TransactionCategories data loaded!");

var transactiontypes  = records.Select(x => new { x.title_type }).ToList();
context.TransactionTypes.AddRange(transactiontypes.Select(x => new TransactionType { Title_type = x.title_type }));
context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] TransactionTypes data loaded!");





var users = records.Select(x => new { x.name, x.email, x.password }).ToList(); ;
context.Users.AddRange(users.Select(x => new User { Name = x.name, Email = x.email, Password = x.password }));
context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] User data loaded!");


foreach (var r in records)
{
    context.Transactions.Add(new Transaction
    {
        Amount= r.amout,
        Description=r.description,
        Date=r.date,
        User=context.Users.First(x=>x.Name==r.name && x.Email == r.email && x.Password == r.password ),
        TransactionCategory=context.TransactionCategories.First(x=>x.Title_categories==r.title_categories),
        TransactionType =context.TransactionTypes.First(x=>x.Title_type==r.title_type),
        PaymentType=context.PaymentTypes.First(x=>x.Payment_method==r.payment_method),
        Currency = context.Currencies.First(x=>x.Title_currency==r.title_currency)
    });
}

context.SaveChanges();
Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Transactions data saved to database!");
