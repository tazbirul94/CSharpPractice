using Demo.WebApi.Models;
using Demo.WebApi.Services;

namespace Demo.WebApi.Repositories
{
    public class ProductRepository : IProductService<Product>
    {
        private readonly ModelContext _db;

        public ProductRepository(ModelContext db)
        {
            _db = db;
        }
        public override async Task<Product?> GetProductById(int id) => await Task.FromResult(_db.Items.FirstOrDefault(x => x.Id == id));
    }
}
