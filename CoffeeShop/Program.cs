// See https://aka.ms/new-console-template for more information
using CoffeeShop;

Console.WriteLine("Hello, World!");
// Egyik teszt
Drink drink = new Drink("latte", 2000, true, false);
Drink drink1 = new Drink("latte", 2000, true, false);
Console.WriteLine(drink.Describe());
// Másik teszt
Customer customer1 = new Customer("A", true);
Customer customer2=new Customer("B", false);

customer1.AddPoints(6);
customer2.AddPoints(6);
Console.WriteLine(customer1.Points.ToString());
Console.WriteLine(customer2.Points.ToString());