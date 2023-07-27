using Demo.WebApi.Models;
using Demo.WebApi.Services;

namespace Demo.WebApi.Repositories
{
    public class Product2Repository : IProductService<Product>
    {
        private readonly ModelContext _db = new ModelContext();

        public Product2Repository()
        {
            _db.Items.Add(new Product() { Id = 1, Name ="Hello"});
        }
        public override async Task<Product?> GetProductById(int id) => await Task.FromResult(_db.Items.FirstOrDefault(x => x.Id == id));

        public override async Task<List<Product>> GetProducts()
        {
            return await Task.FromResult(new List<Product>());
        }
    }
}
