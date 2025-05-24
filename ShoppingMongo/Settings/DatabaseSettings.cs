namespace ShoppingNightMongo.Settings
{
    public class DatabaseSettings:IDatabaseSettings
    {
        public string ConnectionStrings { get; set; }
        public string DatabaseName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string SliderCollectionName { get; set; }
    }
}
