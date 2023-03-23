using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks
{
    class Connection
    {
        private MongoClient conn = null;
        private IMongoDatabase database = null;

        public Connection() {
            conn = new MongoClient("mongodb://localhost:27017");
            database = conn.GetDatabase("GestionStocks");
        }

        public IMongoCollection<T> getCollection<T>(string collectionName)
        {
            IAsyncCursor<string> collections = database.ListCollectionNames();
            foreach (string name in collections.ToList())
            {
                Console.WriteLine(name);
                if (name == collectionName)
                {
                    Console.WriteLine(collectionName);
                    return database.GetCollection<T>(collectionName);
                }
            }
            return null;
        }


    }   
}
