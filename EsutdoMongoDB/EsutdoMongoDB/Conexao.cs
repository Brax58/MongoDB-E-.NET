using MongoDB.Driver;

namespace EsutdoMongoDB
{
    public class Conexao
    {
        public IMongoDatabase Connect()
        {
            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
            return client.GetDatabase("Loja");
        }
    }
}
