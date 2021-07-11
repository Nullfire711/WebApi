using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
        { 
        }

        public DbSet<Client> Clients { get; set; }
    }
}
