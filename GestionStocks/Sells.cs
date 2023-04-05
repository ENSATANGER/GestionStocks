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
    internal class Sells
    {
        private static Connection conn = new Connection();

        private static IMongoCollection<Sells> collection = conn.getCollection<Sells>("Sells");



    }
}
