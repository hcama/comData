using comData.core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comData.data.Repositories
{
    public class ClienteRepository : IClienteService
    {
        private AplicationDbContext context = new AplicationDbContext();
 
        public IEnumerable<core.Models.Cliente> getTodosClientes()
        {
            return context.Clientes.ToList();
        }
        public core.Models.Cliente getClienteId(int id)
        {
            return context.Clientes
            .SingleOrDefault(m => m.Id == id);           
        }

        public core.Models.Cliente createCliente(core.Models.Cliente newCliente)      {
            
            context.Clientes.Add(newCliente);
            context.SaveChanges();
            return newCliente;
        }

        public void updateCliente(core.Models.Cliente clienteToBeUpdated, core.Models.Cliente cliente)
        {
            clienteToBeUpdated.Nombre = cliente.Nombre;
            clienteToBeUpdated.ApellidoPaterno = cliente.ApellidoPaterno;
            clienteToBeUpdated.ApellidoMaterno = cliente.ApellidoMaterno;
            clienteToBeUpdated.FechaNacimiento = cliente.FechaNacimiento;          
            context.SaveChanges();
        }

        public void deleteCliente(core.Models.Cliente cliente)
        {
            context.Clientes.Remove(cliente);
            context.SaveChanges();
        }
    }
}
