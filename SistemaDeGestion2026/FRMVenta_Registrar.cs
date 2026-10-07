using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion2026
{
    public partial class FRMVenta_Registrar : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
            private aclient cliente=new aclient();
            private bool clienteok=false;
        #endregion
        public FRMVenta_Registrar()
        {
            InitializeComponent();
        }

        private void TXTNITCliente_Leave(object sender, EventArgs e)
        {
            cliente.caclnitcli = TXTNITCliente.Text;
            if (cliente.ObtenerDatosNIT())
            {
                TXTNombreCliente.Text = cliente.caclrazcli;
                clienteok = true;
            }
            else
            { 
                TXTNombreCliente.Text = "Nombre del cliente";
                clienteok = false;
            }
        }

        private void BTNBuscarUsuario_Click(object sender, EventArgs e)
        {
            FRMCliente_Buscar a = new FRMCliente_Buscar();
            a.ShowDialog();
            if (a.seleccionadoOk)
            {
                this.cliente = a.cliente;
                this.clienteok = true;
                TXTNITCliente.Text = cliente.caclnitcli;
                TXTNombreCliente.Text = cliente.caclrazcli;
            }
            else
            {
                this.clienteok = false;
                TXTNITCliente.Text = "";
                TXTNombreCliente.Text = "Nombre del cliente";
            }
        }
    }
}
