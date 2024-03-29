﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ClienteBL
    {
        private ClienteDAO clienteDao = new ClienteDAO();

        public ClienteBL()
        {

        }

        public List<Cliente> GetAll()
        {
            return clienteDao.GetAll();
        }

        public List<Cliente> ByPlacas(Cliente cliente)
        {
            return clienteDao.ByPlacas(cliente);
        }

        public Cliente ByPlaca(Cliente cliente)
        {
            return clienteDao.ByPlaca(cliente);
        }

        public bool Existe(Cliente cliente)
        {
            return clienteDao.Existe(cliente);
        }

        public List<Cliente> ByName(Cliente cliente)
        {
            return clienteDao.ByNames(cliente);
        }

        public Cliente ByID(Cliente cliente)
        {
            return clienteDao.ByID(cliente);
        }

        public void Update(Cliente cliente)
        {
             clienteDao.Update(cliente);
        }

        public Cliente Insert(Cliente cliente)
        {
            return clienteDao.Add(cliente);
        }

        public void Delete(Cliente cliente)
        {
            clienteDao.Delete(cliente);
        }

        public DataTable GetOrdensServico(Cliente cliente)
        {
            cliente = clienteDao.ByPlaca(cliente);

            if (cliente != null)
            {
                ServicoBL servicoBL = new ServicoBL();
                IList<Servico> servicos = servicoBL.GetServicosDoCliente(cliente);
                DataTable table = ClienteTabela.CriaTabelaOrdemServico(servicos);
                return table;
            }

            return new DataTable();
        }

        public DataTable GetOrdensServico(Servico servico)
        {
            Cliente cliente = clienteDao.ByPlaca(servico.Cliente);
            if (cliente.ID > 0)
            {
                servico.Cliente = cliente;

                ServicoBL servicoBL = new ServicoBL();
                IList<Servico> servicos = servicoBL.GetServicosDoCliente(servico);
                DataTable table = ClienteTabela.CriaTabelaOrdemServico(servicos);
                return table;
            }

            return new DataTable();
        }

    }
}
