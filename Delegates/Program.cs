﻿using Delegates;
using DemoLibrary;

Console.WriteLine("=========================================================================");
Console.WriteLine("=========================== DELEGATE EXAMPLE ============================");
DelegateDemo delegateObject = new();

Console.WriteLine();

Console.WriteLine("=========================================================================");
Console.WriteLine("============================ FUNC EXAMPLE ===============================");
FuncDemo funcDemo = new();

Console.WriteLine();

Console.WriteLine("=========================================================================");
Console.WriteLine("============================ ACTION EXAMPLE =============================");

ActionDemo action = new();
action.PrintAction();

ProductModel test = new() { ItemName = "Test Item", Price = 20 };
Console.WriteLine(test);

Console.ReadKey();



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
//            Console.WriteLine($"The subtoal is {subTotal:C2}");
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

//ShoppingCartModel cart = new();

//PopulateCartWithDemoData();

//Console.WriteLine($"The total for the cart is {cart.GernerateTotal(SubTotalAlert):C2}");

////Console.WriteLine();
//Console.Write("Please press any key to exit the application...");
//Console.ReadKey();

//void SubTotalAlert(decimal subTotal)
//{
//    Console.WriteLine($"The subtoal is {subTotal:C2}");
//}

//void PopulateCartWithDemoData()
//{
//    cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
//    cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
//    cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
//    cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
//}




