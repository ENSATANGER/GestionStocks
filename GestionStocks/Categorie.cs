using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Collections.Generic;
using System;

namespace GestionStocks
{
    class Categorie
    {
        private static Connection conn = new Connection();

        // collection that allow as to call crud methods
        private static IMongoCollection<Categorie> collection = conn.getCollection<Categorie>("Categories");

        // indicates that the "Id" property is the primary key
        [BsonId]
        //specifies that this property should be stored as a MongoDB Object ID
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }

        public Categorie() { }
        public Categorie(string nom, string description)
        {
            this.nom = nom;
            this.description = description;
        }

        //Using a Task return type in a method declaration is a way to indicate that
        //the method will perform some asynchronous operation and return a Task object 
        //A Task object represents an asynchronous operation that can be monitored
        public Task Create()
        {
            if(select().Count == 0)
                return collection.InsertOneAsync(this);
            return null;
        }
        
        public Task Update()
        {
            var filter = Builders<Categorie>.Filter.Eq("Id", Id);
            //IsUpsert = true means that if it doesn't exist insert it
            return collection.ReplaceOneAsync(filter,this);
        }
        public Task Delete()
        {
            if (select().Count != 0)
                return collection.DeleteOneAsync(c => c.Id == Id);
            return null;
        }
        public List<Categorie> select()
        {
            var filter = Builders<Categorie>.Filter.Eq("nom", nom);
            var result =  collection.Find(filter);
            return result.ToList();
        }

        //search using like %
        public List<Categorie> search(string nom)
        {
            var regex = new BsonRegularExpression(".*" + nom + ".*", "i"); // "i" makes it case-insensitive
            var filter = Builders<Categorie>.Filter.Regex("nom", regex);
            var result = collection.Find(filter);
            return result.ToList();
        }
        public static List<Categorie> Select()
        {
            var result = collection.Find(_=>true);
            return result.ToList();
        }

    }
}
