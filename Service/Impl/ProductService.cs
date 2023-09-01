using IWantToBuy.Data.Repository;
using IWantToBuy.Models;

namespace IWantToBuy.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProducts() =>
            _repository.GetAllProducts();

        public Product? GetProductFromId(int id) => 
            _repository.GetProductFromId(id);
            
        public void SaveProduct(Product product) =>
            _repository.SaveProduct(product);

        public void Update(Product product) =>
            _repository.Update(product);

        public void Delete(int id)
        {
            Product product = GetProductFromId(id);
            _repository.Delete(product!);
        }
    }
}