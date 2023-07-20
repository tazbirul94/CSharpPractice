namespace DemoLibrary;

public class ShoppingCartModel
{
    public delegate void MentionDiscount(decimal subTotal);
    public List<ProductModel> Items { get; set; } = new();

    public decimal GernerateTotal(MentionDiscount mentionDiscount)
    {
        decimal subTotal = Items.Sum(x => x.Price);

        mentionDiscount(subTotal);

        if (subTotal > 100)
        {
            return subTotal *= 0.80M;
        }
        else if (subTotal > 50)
        {
            return subTotal *= 0.85M;
        }
        else if (subTotal > 10)
        {
            return subTotal *= 0.90M;
        }
        else
        {
            return subTotal;
        }
    }
}