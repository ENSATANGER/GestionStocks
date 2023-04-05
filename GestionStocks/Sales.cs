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
    internal class Sales
    {
        private static Connection conn = new Connection();

        private static IMongoCollection<Sales> collection = conn.getCollection<Sales>("Sells");



    }
}
