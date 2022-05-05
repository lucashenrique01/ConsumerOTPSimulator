using BrokerContextNamespace;
using ConsumerControllerNamespace;
using ConsumerApp.Services;

namespace ConsumerApp
{
    class Program
    { 
        static void Main(string[] args)
        {   
            EventTransactionService eventService = new EventTransactionService();
            eventService.createTable();
            BrokerContext brokerContext = new BrokerContext();
            string topicName = brokerContext.getTopic();
            ConsumerController consumerController = new ConsumerController();
            consumerController.ConsumerTopic(topicName);
        }
    }
}