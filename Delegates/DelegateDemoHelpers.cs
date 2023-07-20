using DemoLibrary;

public static class DelegateDemoHelpers
{
    public static ShoppingCartModel cart = new();
    public static void PopulateCartWithDemoData()
    {
        cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
        cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
        cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
        cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
    }

    public static void SubTotalAlert(decimal subTotal)
    {
        Console.WriteLine($"The subtoal is {subTotal:C2}"); //C2 converts the decimal into money and puts two decimal formats
    }
}