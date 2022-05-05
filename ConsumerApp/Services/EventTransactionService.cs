using System;
using EventDaoNamespace;
using ConsumerApp.Models;
using ConsumerApp.Converters;

namespace ConsumerServiceNamespace{

    public class EventTransactionService{

        EventTransactionDAO eventDAO = new EventTransactionDAO();

        public void save(ClientOTP clientOTP){
            EventTransaction eventTransaction = new EventTransaction();

            Client client = ClientConverter.jsonToClient(clientOTP.getCliente());
            eventTransaction.setToken(tokenGenerate());
            eventTransaction.setIdClient(client.getIdCliente());
        }
        public EventTransaction returnByClientToken(string idCliente, string token){}
        public void createTable(){
            eventDAO.createTableEventTransaction();
        }
        private string tokenGenerate(){
            Random tokenRandom = new Random();
            tokenRandom.Next(100000,999999);
            string token = Convert.ToString(tokenRandom);
            return token;
        }  
    }
}