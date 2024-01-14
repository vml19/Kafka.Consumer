namespace Kafka.Consumer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var consumer = new Consumer();
            consumer.ConsumeMessage();
        }
    }
}