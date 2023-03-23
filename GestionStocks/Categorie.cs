using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace GestionStocks
{
    class Categorie
    {
        // indicates that the "Id" property is the primary key
        [BsonId]
        //specifies that this property should be stored as a MongoDB Object ID
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
    }
}
