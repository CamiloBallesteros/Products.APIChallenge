using Products.Core.Entities;
using Products.Core.Interfaces;
using Products.Infrastructure.Data;

namespace Products.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ApplicationDBContext context;
        public ProductRepository(ApplicationDBContext products)
        {
            this.context = context;
        }

        public bool CreateProduct(ProductsEntity product)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        public ProductsEntity GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductsEntity> GetProductsList()
        {
            try
            {
                List<ProductsEntity> productsList = context.Products.ToList();
                return productsList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateProduct(ProductsEntity product)
        {
            throw new NotImplementedException();
        }
    }
}
