using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Collections.Generic;

namespace GestionStocks
{
    class Categorie
    {
        Connection conn = null;

        // collection that allow as to call crud methods
        private IMongoCollection<Categorie> collection = null;

        // indicates that the "Id" property is the primary key
        [BsonId]
        //specifies that this property should be stored as a MongoDB Object ID
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }

        public Categorie(string nom, string description)
        {
            conn = new Connection();
            this.nom = nom;
            this.description = description;
            collection = conn.getCollection<Categorie>("Categories"); 
        }

        //Using a Task return type in a method declaration is a way to indicate that
        //the method will perform some asynchronous operation and return a Task object 
        //A Task object represents an asynchronous operation that can be monitored
        public Task Create(Categorie categorie)
        {
            if(Select(categorie.nom).Count != 0)
                return collection.InsertOneAsync(categorie);
            return null;
        }
        
        public Task Update(Categorie categorie)
        {
            var filter = Builders<Categorie>.Filter.Eq("Id", categorie.Id);
            //IsUpsert = true means that if it doesn't exist insert it
            return collection.ReplaceOneAsync(filter,categorie, new ReplaceOptions { IsUpsert = false});
        }

        public List<Categorie> Select(string nom)
        {
            var filter = Builders<Categorie>.Filter.Eq("nom", nom);
            var result =  collection.Find(filter);
            return result.ToList();
        }


    }
}
