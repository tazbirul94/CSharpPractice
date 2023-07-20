using DemoLibrary;
using System.Runtime.CompilerServices;

ShoppingCartModel cart = new();

PopulateCartWithDemoData();

Console.WriteLine($"The total for the cart is {cart.GernerateTotal():C2}");

//Console.WriteLine();
Console.Write("Please press any key to exit the application...");
Console.ReadKey();

void PopulateCartWithDemoData()
{
    cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
    cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
    cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
    cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
}

