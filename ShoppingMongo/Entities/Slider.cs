using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingMongo.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SliderId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImageUrl { get; set; }
        public string Title2 { get; set; }
        public string Subtitle2 { get; set; }
        public string ImageUrl2 { get; set; }
        public string Title3 { get; set; }
        public string Subtitle3 { get; set; }
        public string ImageUrl3 { get; set; }
    }
}
