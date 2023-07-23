using FactoryPattern.AbstractProducts;

namespace FactoryPattern;

class Client
{
    private readonly Shirt _shirt;
    private readonly Trouser _trouser;

    public Client(ClothesFactory factory)
    {
        _shirt = factory.CreateShirt();
        _trouser = factory.CreateTrouser();
    }

    public string DescribeYourClothes()
    {
        return $"Today I'm dressed in {_shirt.GetType().Name} and {_trouser.GetType().Name}";
    }
}
