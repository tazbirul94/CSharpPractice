using FactoryPattern.AbstractProducts;

namespace FactoryPattern;

abstract class ClothesFactory
{
    public abstract Shirt CreateShirt();
    public abstract Trouser CreateTrouser();
}
