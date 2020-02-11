using comData.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comData.core.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> getTodosClientes();
        Cliente getClienteId(int id);
        Cliente createCliente(Cliente newCliente);
        void updateCliente(Cliente clienteToBeUpdated, Cliente cliente);
        void deleteCliente(Cliente cliente);
    }
}
