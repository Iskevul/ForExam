using MongoDB.Driver;
using System.Collections.Generic;

namespace NacharEkz.Data
{
    public static class DB
    {
        public static void AddUserToDatabase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<User>("users");
            collection.InsertOne(user);
        }
    }
}
