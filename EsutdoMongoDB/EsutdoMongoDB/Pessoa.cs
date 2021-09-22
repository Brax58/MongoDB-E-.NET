using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace EsutdoMongoDB
{
    public class Pessoa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public ObjectId Id { get; private set; }

        [BsonElement("Nome")]
        public string Nome { get; set; }

        [BsonElement("Idade")]
        public int? Idade { get; set; }

        [BsonElement("DataNascimento")]
        public DateTime? DataNascimento { get; set; }

        [BsonElement("Sexo")]
        public string Sexo { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }

        public void AddId()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
}
