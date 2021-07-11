using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.ClientData
{
    public class MockClientData : IClientData
    {
        private List<Client> clients = new List<Client>()
        {
            new Client()
            {

                Id = Guid.NewGuid(),
                Name = "Client1",
                DateOfDeal = "11.07.2021"

            },

            new Client()
            {

                Id = Guid.NewGuid(),
                Name = "Client2",
                DateOfDeal = "14.07.2021"

            }
        };

        public Client AddClient(Client client)
        {
            client.Id = Guid.NewGuid();
            clients.Add(client);
            return client;
        }

        public Client DeleteClient(Client client)
        {
            clients.Remove(client);
            return client;
        }

        public Client EditClient(Client client)
        {
            var existingClient = GetClient(client.Id);
            existingClient.Name = client.Name;
            return client;
        }

        public Client GetDate(DateTime date)
        {
            return clients.SingleOrDefault(x => x.DateOfDeal == date.ToString());
        }

        public Client GetClient(Guid id)
        {
            return clients.SingleOrDefault(x=> x.Id == id);
        }

        public List<Client> GetClients()
        {
            return clients;
        }
    }
}
