using ShoppingMongo.Dtos.ProductDto;
using ShoppingMongo.Dtos.SliderDto;

namespace ShoppingMongo.Serivces.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAsync(SliderUpdateDto updateSliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetSliderByIdDto> GetSliderByIdAsync(string id);
    }
}