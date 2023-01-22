using Products.Core.Entities;

namespace Products.Core.Interfaces
{
    public interface IProductRepository
    {
        public List<ProductsEntity> GetProductsList();
        public ProductsEntity GetProductById(int id);
        public bool CreateProduct(ProductsEntity product);
        public bool UpdateProduct(ProductsEntity product);
        public bool DeleteProductById(int id);
    }
}
