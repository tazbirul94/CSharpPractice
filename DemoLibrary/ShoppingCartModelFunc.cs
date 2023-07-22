namespace DemoLibrary;

public class ShoppingCartModelFunc
{
    public delegate void MentionDiscount(decimal subTotal);
    public List<ProductModel> Items { get; set; } = new();

    public decimal GernerateTotal(
        MentionDiscount mentionDiscount,
        Func<List<ProductModel>, decimal, decimal> calculateDiscountedTotal
        )
    {
        decimal subTotal = Items.Sum(x => x.Price);

        mentionDiscount(subTotal);

        return calculateDiscountedTotal(Items, subTotal);
    }
}
