using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace GestionStocks
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*Produits produits = new Produits();
            produits.nom = "Samsung";
            produits.categorie = "Telephones";
            produits.description = "Samsung";
            produits.prix = 0;
            produits.poids = 0;
            produits.quantite = 7;
            Console.WriteLine(Produits.collection);
            List<Produits> lp = produits.select();
            foreach(Produits produit in lp) { Console.WriteLine(produit); }*/


            (new MDI()).ShowDialog();

            /*Categorie categorie = new Categorie( "Informatique", "pc + écran + clavier");
            *//*await categorie.Create();*//*

            foreach(Categorie value in Categorie.Select())
                Console.WriteLine(value.nom+" ; "+value.description);*/

            //Asynchronous operations in C# allow you to perform non-blocking operations
            // the await keyword allows the calling code to wait for the completion of this operation before proceeding.
            /*await collection.InsertOneAsync(categorie);

            var results = await collection.FindAsync(_ => true);

            foreach (var result in results.ToList())
            {
                Console.WriteLine(result.nom + ": " + result.description);
            }*/

            /*Produits p = Produits.searchByName("sd");
            Console.WriteLine(p.prix.ToString());*/
            Console.ReadLine();
        }
    }
}
