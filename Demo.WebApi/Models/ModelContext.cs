namespace Demo.WebApi.Models
{
    public class ModelContext
    {
        public List<Product> Items { get; set; } = new();
        public List<Article> ArticleItems { get; set; } = new();
    }
}
