using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redis
{
    internal class Client
    {
        public string Cpf { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Client(string cpf, string name, string email)
        {
            Cpf = cpf;
            Name = name;
            Email = email;
        }
    }
}
