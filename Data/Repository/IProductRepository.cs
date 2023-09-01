using IWantToBuy.Models;

namespace IWantToBuy.Data.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductFromId(int id);
        void SaveProduct(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}