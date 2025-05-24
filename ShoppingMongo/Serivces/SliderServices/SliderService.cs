using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Dtos.SliderDto;
using ShoppingMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingMongo.Serivces.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;
        public SliderService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionStrings);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var values = _mapper.Map<Slider>(createSliderDto);  
            await _sliderCollection.InsertOneAsync(values);
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _sliderCollection.DeleteOneAsync(x=>x.SliderId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var values = await _sliderCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);  
        }

        public async Task<GetSliderByIdDto> GetSliderByIdAsync(string id)
        {
            var values = await _sliderCollection.Find(x=>x.SliderId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSliderByIdDto>(values);
        }

        public async Task UpdateSliderAsync(SliderUpdateDto updateSliderDto)
        {
            var values = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x=>x.SliderId==updateSliderDto.SliderId, values);    
        }
    }
}
