using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.ClientData
{
    public interface IClientData
    {
        List<Client> GetClients();

        Client GetClient(Guid id);

        Client GetDate(DateTime date);

        Client AddClient(Client client);

        Client DeleteClient(Client client);

        Client EditClient(Client client);

    }
}
