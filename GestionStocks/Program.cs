using System;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GestionStocks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Connection con = new Connection();
            con.getCollection<Categorie>("hhh");

            /*Categorie categorie = new Categorie { nom = "Informatique", description = "pc + écran + clavier" };

            //Asynchronous operations in C# allow you to perform non-blocking operations
            // the await keyword allows the calling code to wait for the completion of this operation before proceeding.
            await collection.InsertOneAsync(categorie);

            var results = await collection.FindAsync(_ => true);

            foreach (var result in results.ToList())
            {
                Console.WriteLine(result.nom + ": " + result.description);
            }*/
        }
    }
}
