﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ShoppingMongo.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageUrl { get; set; }
        public string CategorySubTitle { get; set; }
    }
}
