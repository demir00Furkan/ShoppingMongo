using ShoppingMongo.Dtos.CategoryDto;

namespace ShoppingMongo.Serivces.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(CreateCategoryDto categoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto categoryDto);    
        Task DeleteCategoryAsync(string id);
        Task<GetCategoryByIdDto> GetCategoryByIdDtoAsync(string id);
    }
}
