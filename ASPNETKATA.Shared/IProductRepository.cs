using System.Collections.Generic;
using ASPNETKATA.Shared;

namespace ASPNETKATA.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void DeleteProduct(int productId);
        void UpdateProduct(Product prod);
        void InsertProduct(Product prod);
    }
}