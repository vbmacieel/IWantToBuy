using IWantToBuy.Models;

namespace IWantToBuy.Data.Repository.Impl
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts() =>
            _context.Produts;

        public Product? GetProductFromId(int id) =>
            _context.Produts.Find(id);

        public void SaveProduct(Product product)
        {
            _context.Produts.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Produts.Update(product);
            _context.SaveChanges();
        }
        
        public void Delete(Product product)
        {
            _context.Produts.Remove(product);
            _context.SaveChanges();
        }    
    }
}