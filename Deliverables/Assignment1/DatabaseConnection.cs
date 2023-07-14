using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows;

namespace Assignment1
{
    class DatabaseConnection
    {
        private static readonly string connectionUri = "mongodb+srv://aryanarora:Aryan@desk-app-cluster.zvakkim.mongodb.net/?retryWrites=true&w=majority";

        public static void AddProduct(FarmersMarket fm)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("products");

            try
            {
                collection.InsertOne(new BsonDocument
                {
                    {"name", fm._name},
                    {"weight", fm._weight},
                    {"price", fm._price}
                });

                MessageBox.Show("Product Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.ToString());
            }
        }

        public static List<FarmersMarket> ReadProducts()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("products");

            var documents = collection.Find(new BsonDocument()).ToList();

            List<FarmersMarket> products = new List<FarmersMarket>();

            foreach (var document in documents)
            {
                FarmersMarket product = new FarmersMarket(document["name"].AsString, document["weight"].AsDouble, document["price"].AsDouble);
                products.Add(product);
            }

            return products;
        }


        public static void UpdateProduct(FarmersMarket fm)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("products");

            var filter = Builders<BsonDocument>.Filter.Eq("name", fm._name);
            var update = Builders<BsonDocument>.Update
                .Set("name", fm._name)
                .Set("weight", fm._weight)
                .Set("price", fm._price);

            collection.UpdateOne(filter, update);
        }

        public static void DeleteProduct(string name)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("products");

            var filter = Builders<BsonDocument>.Filter.Eq("name", name);
            collection.DeleteOne(filter);
        }


    }
}