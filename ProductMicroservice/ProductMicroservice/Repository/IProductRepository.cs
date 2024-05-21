using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        public Product GetProductByID(int id);
        public IEnumerable<Product> GetProducts();
        public void InsertProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}