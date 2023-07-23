using FactoryPattern.AbstractProducts;
using FactoryPattern.Products;

namespace FactoryPattern.Factories
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trouser CreateTrouser()
        {
            return new Jeans();
        }
    }
}
