using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace EsutdoMongoDB
{
    public interface IPessoaService
    {
        string InsertService(Pessoa pessoa);
        Pessoa GetService(string nome);
        void DeleteService(string id);
    }
}
