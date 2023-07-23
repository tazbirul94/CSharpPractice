using FactoryPattern.AbstractProducts;
using FactoryPattern.Products;

namespace FactoryPattern.Factories;

internal class ElegantClothesFactory : ClothesFactory
{
    public override Shirt CreateShirt()
    {
        return  new DressShirt();
    }

    public override Trouser CreateTrouser()
    {
        return new SuitTrouser();
    }
}
