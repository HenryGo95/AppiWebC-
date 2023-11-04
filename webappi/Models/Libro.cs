namespace webappi.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Libro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
    }
}

