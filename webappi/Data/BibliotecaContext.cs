using MongoDB.Driver;
using webappi.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

public class BibliotecaContext
    {
        private readonly IMongoDatabase _db;

        public BibliotecaContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("DefaultConnection"));
            _db = client.GetDatabase("Biblioteca");
        }

        public IMongoCollection<Libro> Libros => _db.GetCollection<Libro>("Libros");
    }



