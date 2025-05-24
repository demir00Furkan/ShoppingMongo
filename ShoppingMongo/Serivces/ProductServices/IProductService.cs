using ShoppingMongo.Dtos.ProductDto;

namespace ShoppingMongo.Serivces.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetProductByIdDto> GetProductByIdDtoAsync(string id);
    }
}
