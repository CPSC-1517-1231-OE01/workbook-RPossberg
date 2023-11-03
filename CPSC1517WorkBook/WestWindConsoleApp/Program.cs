// See https://aka.ms/new-console-template for more information


using WestWindSystem.DAL;

var db = new WestWindContext();
var countOfCustomers = db.Customers.Count();

Console.WriteLine($"There are {countOfCustomers} customers in the database.");

var customer = db.Customers.FirstOrDefault();


Console.WriteLine($"The first customer is {customer.ContactName}");
