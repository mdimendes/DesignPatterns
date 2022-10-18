// See https://aka.ms/new-console-template for more information
using Visitor;

Console.Title = "Visitor";

// creeate a container & add concrete elements
var container = new Container();

container.Customers.Add(new Customer("Sophie", 500));
container.Customers.Add(new Customer("Karen", 1000));
container.Customers.Add(new Customer("Sven", 800));
container.Employees.Add(new Employee("Kevin", 18));
container.Employees.Add(new Employee("Tom", 5));

// create visitor
DiscountVisitor discountVisitor = new();

// pass it through
container.Accept(discountVisitor);

// write our gathered amount
Console.WriteLine($"Total Discount: {discountVisitor.TotalDiscountGiven}");

Console.ReadKey();


