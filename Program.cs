using ServiceStack.Redis;

namespace redis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = "localhost:6379";
            var key1 = "123456789";
            var key2 = "987654321";

            var client1 = new Client(key1, "John Doe", "john@doe.com");
            var client2 = new Client(key2, "Jane Doe", "jane@doe.com");

            using (var redis = new RedisClient(host))
            {
                redis.Set<Client>(key1, client1);
                redis.Set<Client>(key2, client2);
                var client1FromRedis = redis.Get<Client>(key1);
                var client2FromRedis = redis.Get<Client>(key2);
                Console.WriteLine("Client 1: {0}", client1FromRedis.Name);
                Console.WriteLine("Client 2: {0}", client2FromRedis.Name);
            }

        }
    }
}