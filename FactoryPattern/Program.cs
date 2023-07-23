using FactoryPattern;
using FactoryPattern.Factories;

//namespace FactoryPattern;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Client entrepreneur = new(new ElegantClothesFactory());
//        Console.WriteLine($"Entreprenuer: {entrepreneur.DescribeYourClothes()}");

//        Client student = new(new CasualClothesFactory());
//        Console.WriteLine($"Student: {student.DescribeYourClothes()}");

//        Console.ReadKey();
//    }
//}

Client entrepreneur = new(new ElegantClothesFactory());
Console.WriteLine($"Entreprenuer: {entrepreneur.DescribeYourClothes()}");

Client student = new(new CasualClothesFactory());
Console.WriteLine($"Student: {student.DescribeYourClothes()}");

Console.ReadKey();

