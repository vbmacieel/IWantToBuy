using IWantToBuy.Models;

namespace IWantToBuy.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductFromId(int id);
        void SaveProduct(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}