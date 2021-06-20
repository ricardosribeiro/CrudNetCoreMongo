using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CrudNetCoreMongo.Domain.Entities
{

    /* A propriedade:
        Necessária para mapear o objeto CLR para a coleção do MongoDB.
        É anotada com BsonId para designar essa propriedade como chave primária do documento.
        É anotado com BsonRepresentatio(BsonType.ObjectId) para permitir a passagem do parâmetro
        como tipo string em cez de uma estrutura ObjectId. O Mongo processa a conversão de string
        para ObjectId.

        A proriedade BookName é anotada com o atributo BsonElement para definir o nome da propriedade
        na coleção do MongoDB.
     */
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
