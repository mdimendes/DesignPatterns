// See https://aka.ms/new-console-template for more information
//using Adapter;
using ClassAdapter;

Console.Title = "Adapter";

//object adapter example
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadKey();
