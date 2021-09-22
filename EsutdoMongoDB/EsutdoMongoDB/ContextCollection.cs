using MongoDB.Driver;

namespace EsutdoMongoDB
{
    public class ContextCollection : IContextCollection
    {
        public IMongoCollection<Pessoa> PessoaCollection() 
        {
            var conexao = new Conexao().Connect();
            return conexao.GetCollection<Pessoa>("Pessoa");
        }
    }
}
