using MongoDB.Bson;
using System;

namespace EsutdoMongoDB
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public string InsertService(Pessoa pessoa)
        {

            if (pessoa is null || pessoa.Price <= 0 && pessoa.Idade <= 0 &&
                string.IsNullOrEmpty(pessoa.Nome) && pessoa.Sexo is null)
                throw new Exception("Pessoa deve ser preenchida corretamente!.");

            pessoa.AddId();
            _repository.Insert(pessoa);
            return pessoa.Id.ToString();
        }

        public Pessoa GetService(string nome) 
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome da pessoa não pode ser vazio!");   
           return _repository.Get(nome);
        }

        public void DeleteService(string idRequisicao) 
        {
            if (string.IsNullOrEmpty(idRequisicao) || idRequisicao.Length != 24)
                throw new Exception("Id da pessoa não pode ser vazio!");

            var id = ObjectId.Parse(idRequisicao);
        }
    }
}
