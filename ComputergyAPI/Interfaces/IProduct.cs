using ComputergyAPI.DTOs.Products;

namespace ComputergyAPI.Interfaces
{
    public interface IProduct
    {
        Task<ProductDTO> CreateProduct(ProductCreateDTO dto);

        Task<ProductDTO> UpdateProduct(ProductUpdateDTO dto);

        Task<bool> RemoveProduct(int id);

        Task<ProductDTO> GetAllProducts();

        Task<ProductDTO> GetOneProdct(int id);

        Task<ProductDTO> SearchProduct(SearchInputProductsDTO input);
    }
}
