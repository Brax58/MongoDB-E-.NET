using MongoDB.Bson;
using System.Threading.Tasks;

namespace EsutdoMongoDB
{
    public interface IPessoaRepository
    {
        Task Insert(Pessoa requisicao);
        Pessoa Get(string nome);
        Task delete(ObjectId id);
    }
}
