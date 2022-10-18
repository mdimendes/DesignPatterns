// See https://aka.ms/new-console-template for more information
using Strategy;

Console.Title = "Strategy";

var order = new Order("Marvin Software", 5, "Visual Studio License");
order.ExportService = new CSVExportService();
order.Export();

order.ExportService = new JsonExportService();
order.Export();

Console.ReadKey();

