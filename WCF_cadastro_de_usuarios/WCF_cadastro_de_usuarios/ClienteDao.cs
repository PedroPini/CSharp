﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_cadastro_de_usuarios
{
    public class ClienteDao
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDao.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            Cliente resultado = ClienteDao.clientes.Where(x => x.Nome.Equals(nome)).FirstOrDefault();
            return resultado;
        }
    }
}
