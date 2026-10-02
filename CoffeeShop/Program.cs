// See https://aka.ms/new-console-template for more information
using CoffeeShop;

Console.WriteLine("Hello, World!");
// Egyik teszt
Drink drink = new Drink("latte", 2000, true, false);
Drink drink1 = new Drink("latte", 2000, true, false);
Console.WriteLine(drink.Describe());
// Másik teszt