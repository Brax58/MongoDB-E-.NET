using MongoDB.Driver;

namespace EsutdoMongoDB
{
    public interface IContextCollection
    {
        IMongoCollection<Pessoa> PessoaCollection();
    }
}
