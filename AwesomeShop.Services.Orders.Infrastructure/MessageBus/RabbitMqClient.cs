using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RabbitMQ.Client;

namespace AwesomeShop.Services.Orders.Infrastructure.MessageBus
{
    public class RabbitMqClient : IMessageBusClient
    {
        private readonly IConnection _connection;
        public RabbitMqClient(ProducerConnection producerConnection)
        {
            _connection = producerConnection.Connection;
        }
        public void Publish(object message, string routingKey, string exchange)
        {
            var channel = _connection.CreateModel();

            var settings = new JsonSerializerOptions {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };

            
            var payload = JsonSerializer.Serialize(message);
            var body = Encoding.UTF8.GetBytes(payload);

            channel.ExchangeDeclare(exchange, "topic", true);

            channel.BasicPublish(exchange, routingKey, null, body);
        }
    }
}