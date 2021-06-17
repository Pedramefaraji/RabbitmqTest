using RabbitMQ.Client;
using System;

namespace Rabbitmq.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };
            using var Connection = factory.CreateConnection();
            using var Channel = Connection.CreateModel();

            DirectExchangePublisher.Publish(Channel);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
