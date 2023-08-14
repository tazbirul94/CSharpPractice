using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace DemoLibrary;

public class ProductModel
{
    public required string ItemName { get; set; }

    public decimal Price { get; set; }

    public override string ToString()
    {
        return "Item: " + ItemName + " " + Price;
    }

   
}
