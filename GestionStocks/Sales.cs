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
    class Sales
    {
        private static Connection conn = new Connection();
        public static IMongoCollection<Sales> collection = conn.getCollection<Sales>("Sales");
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NomClient { get; set; }
        public string NomProduit { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public Sales() { }
        public Sales(string nomClient, string nomProduit, int quantite, float prix)
        {
            this.NomClient = nomClient;
            this.NomProduit = nomProduit;
            this.Quantite = quantite;
            this.Prix = prix;
        }
        public async Task Create()
        {
            await collection.InsertOneAsync(this);

/*            return collection.InsertOneAsync(this);
*/        }
        public Task Update()
        {
            var filter = Builders<Sales>.Filter.Eq("Id", Id);
            //IsUpsert = true means that if it doesn't exist insert it
            return collection.ReplaceOneAsync(filter, this);
        }
        public Task Delete()
        {
            if (select().Count != 0)
                return collection.DeleteOneAsync(c => c.Id == Id);
            return null;
        }
        public List<Sales> select()
        {
            var result = collection.Find(Builders<Sales>.Filter.Empty);
            return result.ToList();
        }
        public List<Sales> search(string NomC)
        {
            var regex = new BsonRegularExpression(".*" + NomC + ".*", "i"); // "i" makes it case-insensitive
            var filter = Builders<Sales>.Filter.Regex("NomClient", regex);
            var result = collection.Find(filter);
            return result.ToList();
        }
        public static List<Sales> Select()
        {
            var result = collection.Find(_ => true);
            return result.ToList();
        }
    }
}
