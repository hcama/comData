using comData.DesktopClient.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comData.DesktopClient.Formularios
{
    public partial class Frm_Cliente : Form
    {
        HttpClient client;
        private string indicador;
        //The URL of the WEB API Service
        string url = "http://localhost:12573/api/cliente";  
        public Frm_Cliente()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
        }


        public async Task<ClienteResource> createCliente(ClienteResource cliente)
        {

            HttpResponseMessage response = await client.PostAsJsonAsync(url, cliente);
            if (response.IsSuccessStatusCode)
            {
                ClienteResource newCliente = await response.Content.ReadAsAsync<ClienteResource>();
                return newCliente;

            }
            return cliente;
           
        }
        public async Task<ClienteResource> updateCliente(ClienteResource cliente)
        {

            HttpResponseMessage response = await client.PutAsJsonAsync(url + "/" + cliente.Id , cliente);
            if (response.IsSuccessStatusCode)
            {
                ClienteResource updatedCliente = await response.Content.ReadAsAsync<ClienteResource>();
                return updatedCliente;
            }
            return cliente; 

        }
        public async Task<bool> deleteCliente(ClienteResource cliente)
        {
 
            HttpResponseMessage response = await client.DeleteAsync (url + "/" + cliente.Id);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<IEnumerable<ClienteResource>> getTodosClientes()
        {

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<ClienteResource> clienteResources = await response.Content.ReadAsAsync<IEnumerable<ClienteResource>>();
                return clienteResources;
            }
            return null;     

        }
        public async Task<ClienteResource> getClienteId(ClienteResource cliente)
        {

            HttpResponseMessage response = await client.GetAsync(url + "/" + cliente.Id);
            if (response.IsSuccessStatusCode)
            {
                ClienteResource clienteResource = await response.Content.ReadAsAsync<ClienteResource>();
                return clienteResource;
            }
            return null;

        }

        private async void Frm_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<ClienteResource> clienteResources;
                clienteResources = await getTodosClientes();
                this.dgv_clientes.DataSource = null;
                dgv_clientes.DataSource = clienteResources;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al mostrar los clientes");
            }    
            
            ToolTip toolTip1 = new ToolTip();         
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;     
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.ibtn_agregarCliente , "Agregar Cliente");
            toolTip1.SetToolTip(this.ib_guardarCliente, "Guardar Cliente");
            toolTip1.SetToolTip(this.ib_ModificarCliente, "Modificar Cliente");
            toolTip1.SetToolTip(this.ibtn_EliminarCliente, "Eliminar Cliente");
            toolTip1.SetToolTip(this.ibtnDeshacer, "Deshacer");
            toolTip1.SetToolTip(this.ibn_BuscarCliente, "Buscar Cliente");
       
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Id = dgv_clientes.Rows[e.RowIndex].Cells[0].Value.ToString() ;
                string Nombre = dgv_clientes.Rows[e.RowIndex].Cells[1].Value.ToString() ;
                string ApellidoPaterno = dgv_clientes.Rows[e.RowIndex].Cells[2].Value.ToString ();
                string ApellidoMaterno = dgv_clientes.Rows[e.RowIndex].Cells[3].Value.ToString ();
                DateTime  FechaNacimiento = Convert.ToDateTime (  dgv_clientes.Rows[e.RowIndex].Cells[4].Value);
                this.lbl_idCliente.Text  = Id;
                this.txt_nombre.Text = Nombre;
                this.txt_apellidopaterno.Text = ApellidoPaterno;
                this.txt_apellidomaterno.Text = ApellidoMaterno;
                this.dtp_fechaNacimiento.Value = FechaNacimiento;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al buscar al cliente");
            }   
        }

        private async void ib_guardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteResource cliente = new ClienteResource();
                cliente.Id = Convert.ToInt32(this.lbl_idCliente.Text.Trim());
                cliente.Nombre = this.txt_nombre.Text.Trim();
                cliente.ApellidoPaterno = this.txt_apellidopaterno.Text.Trim();
                cliente.ApellidoMaterno = this.txt_apellidomaterno.Text.Trim();
                cliente.FechaNacimiento = this.dtp_fechaNacimiento.Value;
                if (indicador == "I")
                {
                    cliente = await createCliente(cliente);
                    if (cliente.Id == 0)
                    {
                        MessageBox.Show("Ocurrio un error al registrar al cliente");
                    }
                    else
                    {
                        MessageBox.Show("Se agrego el cliente");
                        IEnumerable<ClienteResource> clienteResources;
                        clienteResources = await getTodosClientes();
                        this.dgv_clientes.DataSource = null;
                        dgv_clientes.DataSource = clienteResources;
                    }
                }
                else if (indicador == "M")
                {
                    cliente = await updateCliente(cliente);
                    if (cliente != null)
                    {
                        MessageBox.Show("Se actualizo el cliente");

                        IEnumerable<ClienteResource> clienteResources;
                        clienteResources = await getTodosClientes();
                        this.dgv_clientes.DataSource = null;
                        dgv_clientes.DataSource = clienteResources;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al actualizar al cliente");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al conectarse al servidor");
            } 



        }

        private void ibtn_agregarCliente_Click(object sender, EventArgs e)
        {
            indicador = "I";
            this.lbl_idCliente.Text = "0";
            this.txt_nombre.Text = "";
            this.txt_apellidopaterno.Text = "";
            this.txt_apellidomaterno.Text = "";
            this.dtp_fechaNacimiento.Value = DateTime.Now  ;
        }

        private void ib_ModificarCliente_Click(object sender, EventArgs e)
        {
            indicador = "M";
        }

        private async void ibtn_EliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea eliminar el cliente?.", "Eliminar Cliente", MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Information);
            bool elimino;
            ClienteResource cliente = new ClienteResource();
            cliente.Id = Convert.ToInt32(this.lbl_idCliente.Text.Trim());

            if (dr == DialogResult.Yes)
            {
                elimino = await deleteCliente(cliente);
                if (elimino)
                {
                    MessageBox.Show("Se elimino el cliente");
                    IEnumerable<ClienteResource> clienteResources;
                    clienteResources = await getTodosClientes();
                    this.dgv_clientes.DataSource = null;
                    dgv_clientes.DataSource = clienteResources;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar al cliente");
                }
                    
            }
        }

        private async void ibtnDeshacer_Click(object sender, EventArgs e)
        {
            IEnumerable<ClienteResource> clienteResources;
            clienteResources = await getTodosClientes();
            this.dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = clienteResources;

            indicador = "I";
            this.lbl_idCliente.Text = "0";
            this.txt_nombre.Text = "";
            this.txt_apellidopaterno.Text = "";
            this.txt_apellidomaterno.Text = "";
            this.dtp_fechaNacimiento.Value = DateTime.Now;
        }

        private async void ibn_BuscarCliente_Click(object sender, EventArgs e)
        {
            ClienteResource cliente = new ClienteResource();
            cliente.Id = Convert.ToInt32(this.txt_BuscarId.Text.Trim());

            cliente = await getClienteId(cliente);
            if (cliente != null)
            {

                List<ClienteResource> clienteResources = new List<ClienteResource>();
                clienteResources.Add(cliente);
                this.dgv_clientes.DataSource = null;
                dgv_clientes.DataSource = clienteResources;
            }
           
        }
    }
}
