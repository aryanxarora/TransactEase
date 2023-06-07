using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Windows;

namespace TransactEase
{
    class DatabaseConnection
    {
        private readonly string connectionUri = "mongodb+srv://aryanarora:Aryan@desk-app-cluster.zvakkim.mongodb.net/?retryWrites=true&w=majority";

        public void CreateAccount(Account a)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("accounts");

            try
            {
                collection.InsertOne(new BsonDocument
                {
                    {"account" , a.AccountNumber},
                    {"name", a.CustomerName},
                    {"address", a.CustomerAddress},
                    {"phone", a.CustomerPhone},
                    {"sin", a.CustomerSIN},
                    {"balance", a.AccountBalance}
                });

                MessageBox.Show("Account Created!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error", "Information");
            }
        }

        public Account ReadAccount(int accountNumber)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("accounts");

            var filter = Builders<BsonDocument>.Filter.Eq("account", accountNumber);
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                Account account = new Account(document["account"].AsInt32, document["name"].AsString, document["address"].AsString, document["phone"].AsString, document["sin"].AsString, document["balance"].AsDouble);
                return account;
            }

            return null; // Account not found
        }

        public List<Account> ReadAllAccounts()
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("accounts");

            var documents = collection.Find(new BsonDocument()).ToList();

            List<Account> accounts = new List<Account>();

            foreach (var document in documents)
            {
                Account account = new Account(document["account"].AsInt32, document["name"].AsString, document["address"].AsString, document["phone"].AsString, document["sin"].AsString, document["balance"].AsDouble);
                accounts.Add(account);
            }

            return accounts;
        }


        public void UpdateAccount(Account a)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("accounts");

            var filter = Builders<BsonDocument>.Filter.Eq("account", a.AccountNumber);
            var update = Builders<BsonDocument>.Update
                .Set("name", a.CustomerName)
                .Set("address", a.CustomerAddress)
                .Set("phone", a.CustomerPhone)
                .Set("sin", a.CustomerSIN)
                .Set("balance", a.AccountBalance);

            collection.UpdateOne(filter, update);
        }

        public void DeleteAccount(int accountNumber)
        {
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var collection = client.GetDatabase("transactease").GetCollection<BsonDocument>("accounts");

            var filter = Builders<BsonDocument>.Filter.Eq("account", accountNumber);
            collection.DeleteOne(filter);
        }


    }
}
