namespace ShoppingMongo.Dtos.ProductDto
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public DateTime ProductCreateDate { get; set; }
        public string ProductImageUrl1 { get; set; }
        public string ProductImageUrl2 { get; set; }
        public string ProductImageUrl3 { get; set; }
        public string StockCount { get; set; }
        public string CategoryId { get; set; }
    }
}
