using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GestionStocks
{
    internal class Produits
    {
        private static Connection conn = new Connection();

        private static IMongoCollection<Produits> collection = conn.getCollection<Produits>("Produits");

        [BsonId]

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string nom { get; set; }
        public string categorie { get; set; }
        public string description { get; set; }
        public float prix { get; set; }
        public float poids { get; set; }
        public int quantite { get; set; }

        public Produits() { }
        public Produits( string nom, string description, float prix, float poids, int quantite)
        {
            
            this.nom = nom;
            this.description = description;
            this.prix = prix;
            this.poids = poids;
            this.quantite = quantite;
        }

        public Task Create()
        {
            if (select().Count == 0)
                return collection.InsertOneAsync(this);
            return null;
        }

        public Task Update()
        {
            var filter = Builders<Produits>.Filter.Eq("Id", Id);
            return collection.ReplaceOneAsync(filter, this);
        }
        public Task Delete()
        {
            if (select().Count != 0)
                return collection.DeleteOneAsync(c => c.Id == Id);
            return null;
        }
        public List<Produits> select()
        {
            var filter = Builders<Produits>.Filter.Eq("nom", nom);
            var result = collection.Find(filter);
            return result.ToList();
        }

        
        public List<Produits> search(string nom)
        {
            var regex = new BsonRegularExpression(".*" + nom + ".*", "i"); 
            var filter = Builders<Produits>.Filter.Regex("nom", regex);
            var result = collection.Find(filter);
            return result.ToList();
        }
        public static List<Produits> Select()
        {
            var result = collection.Find(_ => true);
            return result.ToList();
        }


    }
}
