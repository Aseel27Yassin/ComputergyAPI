using ComputergyAPI.Contexts;
using ComputergyAPI.DTOs.Products;
using ComputergyAPI.Interfaces;

namespace ComputergyAPI.Services
{
    public class ProductServices : IProduct
    {
        private readonly ComputergyDbContext _computergyDbContext;
        public ProductServices(ComputergyDbContext computergyDbContext)
        {
            _computergyDbContext = computergyDbContext;
        }
        public Task<ProductDTO> CreateProduct(ProductCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetOneProdct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> SearchProduct(SearchInputProductsDTO input)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> UpdateProduct(ProductUpdateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
