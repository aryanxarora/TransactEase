using NUnit.Framework;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    [TestFixture]
    public class TestMethods
    {
        [Test]
        public void AddProduct_Test()
        {
            FarmersMarket product = new FarmersMarket("Test Product", 1, 10);
            DatabaseConnection.AddProduct(product);

            List<FarmersMarket> products = DatabaseConnection.ReadProducts();
            Assert.That(products, Is.Not.Null);
            Assert.That(products.Count, Is.EqualTo(6));

            FarmersMarket insertedProduct = products[5];
            Assert.That(insertedProduct._name, Is.EqualTo("Test Product"));
            Assert.That(insertedProduct._weight, Is.EqualTo(1));
            Assert.That(insertedProduct._price, Is.EqualTo(10));
        }

        [Test]
        public void ReadProducts_Test()
        {
            List<FarmersMarket> products = DatabaseConnection.ReadProducts();

            Assert.That(products, Is.Not.Null);
            Assert.That(products.Count, Is.GreaterThan(0));
        }

        [Test]
        public void UpdateProduct_Test()
        {
            FarmersMarket productToUpdate = new FarmersMarket("Test Product", 1, 10);
            DatabaseConnection.UpdateProduct(productToUpdate);

            List<FarmersMarket> products = DatabaseConnection.ReadProducts();
            Assert.That(products, Is.Not.Null);

            FarmersMarket updatedProduct = products.Find(p => p._name == "Test Product");
            Assert.That(updatedProduct, Is.Not.Null);
        }

        [Test]
        public void DeleteProduct_Test()
        {
            string productName = "Test Product";
            DatabaseConnection.DeleteProduct(productName);

            List<FarmersMarket> products = DatabaseConnection.ReadProducts();
            Assert.That(products, Is.Not.Null);

            FarmersMarket deletedProduct = products.Find(p => p._name == "Test Product");
            Assert.That(deletedProduct, Is.Null);
        }
    }
}
