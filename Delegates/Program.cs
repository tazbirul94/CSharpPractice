using DemoLibrary;

//=================================================================================
//================================ CLASSIC STYLE ==================================
//=================================================================================

//namespace Delegates
//{
//    public class Program
//    {
//        static ShoppingCartModel cart = new();
//        static void Main(string[] args)
//        {
//            PopulateCartWithDemoData();

//            Console.WriteLine($"The total for the cart is {cart.GernerateTotal(SubTotalAlert):C2}");

//            //Console.WriteLine();
//            Console.Write("Please press any key to exit the application...");
//            Console.ReadKey();
//        }

//        private static void SubTotalAlert(decimal subTotal)
//        {
//            Console.WriteLine($"The subtoal is {subTotal:C2}"); // C2 converts the decimal into money and puts two decimal formats
//        }

//        private static void PopulateCartWithDemoData()
//        {
//            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
//            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
//            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
//            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
//        }
//    }
//}

//=================================================================================
//============================= NEW .NET 7 STYLE ==================================
//=================================================================================

ShoppingCartModel cart = new();

PopulateCartWithDemoData();

Console.WriteLine($"The total for the cart is {cart.GernerateTotal(SubTotalAlert):C2}");

//Console.WriteLine();
Console.Write("Please press any key to exit the application...");
Console.ReadKey();

void SubTotalAlert(decimal subTotal)
{
    Console.WriteLine($"The subtoal is {subTotal:C2}"); // C2 converts the decimal into money and puts two decimal formats
}

void PopulateCartWithDemoData()
{
    cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
    cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
    cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
    cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
}