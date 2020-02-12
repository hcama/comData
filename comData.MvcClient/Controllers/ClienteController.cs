using comData.DesktopClient.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace comData.MvcClient.Controllers
{
    public class ClienteController : Controller
    {
        HttpClient client;
        string url = "http://localhost:12573/api/cliente";       
        public ClienteController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
        }

        public ActionResult Index()
        {
            return View("mantenimiento-cliente");
        }


        [HttpPost]
        public async Task<JsonResult> getTodosClientesR()
        {

            return Json(await getTodosClientes());
        }

        [HttpPost]
        public async Task<JsonResult> getClienteIdR(ClienteResource cliente)
        {

            return Json(await getClienteId(cliente));
        }
        [HttpPost]
        public async Task<JsonResult> createClienteR(ClienteResource cliente)
        {

            return Json(await createCliente(cliente));
        }
        [HttpPost]
        public async Task<JsonResult> updateClienteR(ClienteResource cliente)
        {

            return Json(await updateCliente(cliente));
        }
        [HttpPost]
        public async Task<JsonResult> deleteClienteR(ClienteResource cliente)
        {
            bool elimino;
            elimino = await deleteCliente(cliente);
            if (elimino)
            {
                return Json(new { result = elimino });
            }           
            return Json(new { result = elimino });
        }
         async Task<IEnumerable<ClienteResource>> getTodosClientes()
        {

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<ClienteResource> clienteResources = await response.Content.ReadAsAsync<IEnumerable<ClienteResource>>();
                return clienteResources;
            }
            return null;

        }
         async Task<ClienteResource> createCliente(ClienteResource cliente)
         {            
             HttpResponseMessage response = await client.PostAsJsonAsync(url, cliente);
             if (response.IsSuccessStatusCode)
             {
                 ClienteResource newCliente = await response.Content.ReadAsAsync<ClienteResource>();
                 return newCliente;

             }
             return cliente;

         }

         async Task<ClienteResource> getClienteId(ClienteResource cliente)
         {

             HttpResponseMessage response = await client.GetAsync(url + "/" + cliente.Id);
             if (response.IsSuccessStatusCode)
             {
                 ClienteResource clienteResource = await response.Content.ReadAsAsync<ClienteResource>();
                 return clienteResource;
             }
             return null;

         }

         async Task<ClienteResource> updateCliente(ClienteResource cliente)
         {

             HttpResponseMessage response = await client.PutAsJsonAsync(url + "/" + cliente.Id, cliente);
             if (response.IsSuccessStatusCode)
             {
                 ClienteResource updatedCliente = await response.Content.ReadAsAsync<ClienteResource>();
                 return updatedCliente;
             }
             return cliente;

         }
         async Task<bool> deleteCliente(ClienteResource cliente)
         {

             HttpResponseMessage response = await client.DeleteAsync(url + "/" + cliente.Id);
             if (response.IsSuccessStatusCode)
             {
                 return true;
             }
             return false;
         }

    }
}
