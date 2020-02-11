using comData.core.Models;
using comData.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace comData.api.Controllers
{
   public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }
        public IEnumerable<Cliente> getTodosClientes()
        {
            var clientes = _clienteService.getTodosClientes();
            return clientes;
        }
        public Cliente getClienteId(int id)
        {
            var cliente =  _clienteService.getClienteId(id);
            return cliente;
        }

        // POST 
        public Cliente Post([FromBody]Cliente saveClienteResource)
        {
            var newCliente = _clienteService.createCliente(saveClienteResource);
            var cliente =  _clienteService.getClienteId(newCliente.Id);
            return cliente;
        }

        // PUT 
        public Cliente Put(int id, [FromBody] Cliente saveClienteResource)
        {
            var clienteToBeUpdate =  _clienteService.getClienteId(id);
            if (clienteToBeUpdate == null)
                return null ;
            _clienteService.updateCliente(clienteToBeUpdate, saveClienteResource);
            var updatedCliente =  _clienteService.getClienteId(id);
            return updatedCliente;
        }

        // DELETE 
        public void Delete(int id)
        {
            if (id == 0)
                return;
            var cliente =  _clienteService.getClienteId(id);

            if (cliente == null)
                return ;
             _clienteService.deleteCliente(cliente);
            return ;
        }      
    }
}
