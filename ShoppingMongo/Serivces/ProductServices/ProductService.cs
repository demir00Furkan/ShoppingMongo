using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Dtos.ProductDto;
using ShoppingMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingMongo.Serivces.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionStrings);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var values = _mapper.Map<Product>(createProductDto);
            values.ProductCreateDate = DateTime.Now;
            await _productCollection.InsertOneAsync(values);
            
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);

        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values); 
        }

        public async Task<GetProductByIdDto> GetProductByIdDtoAsync(string id)
        {
            var values  = await _productCollection.Find(x=>x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetProductByIdDto>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDto.ProductId, values);
            
        }
    }
}
