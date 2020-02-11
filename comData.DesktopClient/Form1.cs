using comData.DesktopClient.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comData.DesktopClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsm_aplicacionWindow_Click(object sender, EventArgs e)
        {
            Frm_Cliente frmCliente = new Frm_Cliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://localhost:13001");
            Process.Start(sInfo);
        }


    }
}
