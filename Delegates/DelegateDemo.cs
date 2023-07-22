namespace Delegates;
public class DelegateDemo
{
    public DelegateDemo()
    {
        DelegateDemoHelpers.PopulateCartWithDemoData();

        Console.WriteLine($"The total for the cart is {DelegateDemoHelpers.cart.GernerateTotal(DelegateDemoHelpers.SubTotalAlert):C2}");

        //Console.Write("Please press any key to exit the application...");
        //Console.ReadKey();
    }
}
