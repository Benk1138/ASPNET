using System;
using System.Collections.Generic;
using System.Data;
using Testing.Models;

namespace Testing
{
    public class IProductRepository
    {
        public IProductRepository();
            public IEnumerable<Product> GetAllProducts();
        public ProductRepositoryusingSystem.Data;
        {
         
        }
    }
    public ProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }
}
public IEnumerable<Product> GetAllProducts()
{
    return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
}


