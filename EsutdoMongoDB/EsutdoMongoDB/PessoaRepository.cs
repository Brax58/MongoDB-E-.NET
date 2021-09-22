using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace EsutdoMongoDB
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly IContextCollection _context;

        public PessoaRepository(IContextCollection context)
        {
            _context = context;
        }

        public async Task Insert(Pessoa requisicao)
        {
            await _context.PessoaCollection().InsertOneAsync(requisicao);
        }

        public Pessoa Get(string nome)
        {
            var filter = Builders<Pessoa>.Filter.Where(x => x.Nome == nome);
            var result = _context.PessoaCollection().Find(filter).FirstOrDefault();
            System.Console.WriteLine(result.ToString());
            return result;
        }

        public async Task delete(ObjectId id)
        {
            await _context.PessoaCollection().DeleteOneAsync(x => x.Id == id);
        }
    }
}
