using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks
{
    internal class Client
    {
        private static Connection conn = new Connection();

        // collection that allow as to call crud methods
        private static IMongoCollection<Client> collection = conn.getCollection<Client>("Clients");

        // indicates that the "Id" property is the primary key
        [BsonId]
        //specifies that this property should be stored as a MongoDB Object ID
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }


        public Client() { }
        public Client(string name, string telephone, string address)
        {
            this.name = name;
            this.telephone = telephone;
            this.address = address;
        }

        //Using a Task return type in a method declaration is a way to indicate that
        //the method will perform some asynchronous operation and return a Task object 
        //A Task object represents an asynchronous operation that can be monitored

        public Task Create()
        {
            if (select().Count == 0)
                return collection.InsertOneAsync(this);
            return null;
        }

        public Task Update()
        {
            var filter = Builders<Client>.Filter.Eq("Id", Id);
            //IsUpsert = true means that if it doesn't exist insert it
            return collection.ReplaceOneAsync(filter, this);
        }
        public Task Delete()
        {
            if (select().Count != 0)
                return collection.DeleteOneAsync(c => c.Id == Id);
            return null;
        }
        public List<Client> select()
        {
            var filter = Builders<Client>.Filter.Eq("name", name);
            var result = collection.Find(filter);
            return result.ToList();
        }

        //search using like %
        public List<Client> search(string name)
        {
            var regex = new BsonRegularExpression(".*" + name + ".*", "i"); // "i" makes it case-insensitive
            var filter = Builders<Client>.Filter.Regex("name", regex);
            var result = collection.Find(filter);
            return result.ToList();
        }
        public static List<Client> Select()
        {
            var result = collection.Find(_ => true);
            return result.ToList();
        }
    }
}
