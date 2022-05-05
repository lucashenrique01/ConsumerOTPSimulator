using System;
using EventDaoNamespace;
using ConsumerApp.Models;
using ConsumerApp.Converters;

namespace ConsumerApp.Services{

    public class EventTransactionService{

        EventTransactionDAO eventDAO = new EventTransactionDAO();
        private static const int MINUTESADD = 5;

        public void save(Event eventt){
            ClientOTP clientOTP = ClientOTPConverter.jsonToClientOTP(eventt.data);
            EventTransaction eventTransaction = new EventTransaction();

            Client client = ClientConverter.jsonToClient(clientOTP.getCliente());
            eventTransaction.token = tokenGenerate();
            eventTransaction.idClient = client.idCliente;
            eventTransaction.idTransacao = clientOTP.idTransacao;
            eventTransaction.canalSolicitante = clientOTP.canalSolicitante;
            eventTransaction.duracaoToken =  DateTime.Now.AddMinutes(MINUTESADD); 
            eventDAO.insertEventTransaction(eventTransaction);
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