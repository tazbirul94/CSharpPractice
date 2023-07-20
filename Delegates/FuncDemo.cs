using DemoLibrary;

namespace Delegates;

public class FuncDemo
{
    public static ShoppingCartModelFunc cart = new();
    public FuncDemo() {
        PopulateCartWithDemoData();

        Console.WriteLine($"The total for the cart is {cart.GernerateTotal(DelegateDemoHelpers.SubTotalAlert, CalculateLeveledDiscount):C2}");

        Console.Write("Please press any key to exit the application...");
        Console.ReadKey();
    }

    private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
    {
        if (subTotal > 100)
        {
            return subTotal *= 0.80M;
        }
        else if (subTotal > 50)
        {
            return subTotal *= 0.85M;
        }
        else if (subTotal > 10)
        {
            return subTotal *= 0.90M;
        }
        else
        {
            return subTotal;
        }
    }

    public static void PopulateCartWithDemoData()
    {
        cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
        cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
        cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
        cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
    }
}
