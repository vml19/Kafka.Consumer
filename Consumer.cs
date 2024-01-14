using Confluent.Kafka;

namespace Kafka.Consumer
{
    internal class Consumer
    {
        public void ConsumeMessage()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "test-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("test-topic");
            try
            {
                while (true)
                {
                    var message = consumer.Consume();
                    Console.WriteLine($"Received message: {message.Message.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}