using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Client
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DateOfDeal { get; set; }

    }
}
